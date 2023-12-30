using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ScrapeLibrary
{
    public class Class1
    {


        public void ScrapeWebsite(string url)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }
    }
}
