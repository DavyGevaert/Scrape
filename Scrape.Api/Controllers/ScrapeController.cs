using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Scrape.Model;
using System.Net;
using System;

namespace Scrape.Api.Controllers
{
    public class ScrapeController : ApiBaseController
    {
        [HttpGet("Get")]
        public async Task<string> Output_Of_Scrape_Website(string url, string className)
        {
            Vacancy vacancy = new Vacancy();
            var output = "";

            ChromeOptions options = new ChromeOptions();
            //// does not open a browser when using this argument
            options.AddArguments("--headless");

            ////download chromedriver
            ////https://googlechromelabs.github.io/chrome-for-testing/

            var chromeDriverPath = Environment.CurrentDirectory;
            using (var driver = new ChromeDriver(chromeDriverPath, options))
            {
                // "https://www.vdab.be/vindeenjob/vacatures/68015340/junior-back-end-software-developer?source=vindeenjob&medium=vacaturedashboard"

                var vdabJobPath = url;

                // className = "vej-results"

                var jobDescriptionClassName = className;
                driver.Navigate().GoToUrl(vdabJobPath);

                try
                {
                    IWebElement productElement = driver.FindElement(By.ClassName(jobDescriptionClassName));
                    Console.WriteLine(productElement.Text);

                    output = productElement.Text;

                    vacancy.Description = output;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }


            return output;
        }

        //[HttpGet("Get")]
        //public async Task<string> Output_Website(string url)
        //{
        //    var httpClientHandler = new HttpClientHandler { AutomaticDecompression = DecompressionMethods.All };
        //    HttpClient client = new HttpClient(httpClientHandler);

        //    return await client.GetStringAsync(url);
        //}


    }
}
