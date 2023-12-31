using Infrastructuur.Constants;
using Infrastructuur.DTO;
using Infrastructuur.Exceptions;
using Infrastructuur.Services.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuur.Services.Classes
{
    public class HtmlParserService : IHtmlParserService
    {
        public async Task<List<VacancyDescriptionDto>?> JobDescriptionParserAsync(int vacancyAmount, int vacancyNumber)
        {
            var stopwatch = new Stopwatch();
            var vacancyDescriptionDtoList = new ConcurrentBag<VacancyDescriptionDto>();
            var currentVacancyNumber = vacancyNumber;

            var tasks = Enumerable.Range(0, vacancyAmount).Select(async i =>
            {
                stopwatch.Start();
                var options = new ChromeOptions();
                options.AddArguments("--headless");

                using (var driver = new ChromeDriver("chromedriver-win64", options))
                {
                    try
                    {
                        //currentVacancyNumber variable that gets incremented using Interlocked.Increment within each task,
                        //ensuring safe increments across multiple threads.
                        
                        int localVacancyNumber = Interlocked.Increment(ref currentVacancyNumber);
                        var vdabJobPath = $"https://www.vdab.be/vindeenjob/vacatures/{localVacancyNumber}/junior-back-end-software-developer?source=vindeenjob&medium=vacaturedashboard";
                        var jobDescriptionClassName = ClassName.RESULTINFO;
                        driver.Navigate().GoToUrl(vdabJobPath);
                        var productElement = driver.FindElement(By.ClassName(jobDescriptionClassName));
                        if (productElement is not null)
                        {
                            vacancyDescriptionDtoList.Add(new VacancyDescriptionDto { Id = localVacancyNumber, Description = productElement.Text });
                        }
                    }
                    catch (HtmlParserException ex) 
                    {
                        throw new HtmlParserException(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw new HtmlParserException("An error occurred during HTML parsing.", ex);
                    }
                }
            });
            await Task.WhenAll(tasks);
            // performance testing
            stopwatch.Stop();
            var timerResult = stopwatch.Elapsed;

            return vacancyDescriptionDtoList.ToList();
        }
    }
}
