using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestTask.Pages
{
    public class GoogleResultsPage
    {
        public GoogleResultsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector,  Using = ".g")]
        public IList<IWebElement> SearchResults { get; set; }
    }
}
