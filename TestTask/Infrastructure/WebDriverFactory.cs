using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace TestTask.Infrastructure
{
    public class WebDriverFactory
    {
        public IWebDriver GetWebDriver(string name)
        {
            switch (name)
            {
                case "chrome": return new ChromeDriver();
                case "headless chrome":
                    {
                        var chromeOptions = new ChromeOptions();
                        chromeOptions.AddArguments("--headless", "--disable-gpu", "--window-size=1920,1080");
                        return new ChromeDriver(chromeOptions);
                    }
                case "firefox": return new FirefoxDriver();
                default: throw new ArgumentException($"Unknown driver: {name}");
            }
        }
    }
}
