using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using TestTask.Pages;

namespace TestTask.Tests
{
    [TestFixture]
    public class GoogleRequestTests : BaseTest
    {
        private const string Url = "https://www.google.com/";
        private const string InputText = "yandex.ru";
        private const string ExpectedUrl = "https://yandex.ru/";

        [Test]
        public void SearchOnGoogle_UsingYandex_HasYandexLinkInFirstResult()
        {
            driver.Navigate().GoToUrl(Url);
            var homePage = new GoogleHomePage(driver);
            homePage.SearchByText(InputText);
            var resultPage = new GoogleResultsPage(driver);
            var searchResults = resultPage.SearchResults.ToList();

            var firstSelectedElement = searchResults
                .First()
                .FindElement(By.CssSelector(".rc a"))
                .GetAttribute("href");

            Assert.AreEqual(ExpectedUrl, firstSelectedElement, "The result is not correct");
        }
    }
}
