using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using TestTask.Infrastructure;

namespace TestTask.Tests
{
    public class BaseTest
    {
        private const string DefaultBrowser = "chrome";
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appconfig.json", true)
                .Build();


            var browser = config["browser"];
            if (browser == null)
            {
                browser = DefaultBrowser;
            }

            driver = new WebDriverFactory().GetWebDriver(browser);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
