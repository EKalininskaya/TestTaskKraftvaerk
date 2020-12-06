using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestTask.Pages
{
    public class GoogleHomePage
    {
        public GoogleHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement SearchInput { get; set; }

        public void SearchByText(string inputText)
        {
            SearchInput.Click();
            SearchInput.Clear();
            SearchInput.SendKeys(inputText);
            SearchInput.Submit();
        }
    }
}
