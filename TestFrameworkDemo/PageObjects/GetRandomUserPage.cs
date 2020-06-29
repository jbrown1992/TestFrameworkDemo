using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestFrameworkDemo.Helper;

namespace TestFrameworkDemo.PageObjects
{
    public class GetRandomUserPage
    {
        IWebDriver _driver;
        string url = "https://www.seleniumeasy.com/test/dynamic-data-loading-demo.html";
        IWebElement getNewUserButton => _driver.FindElement(By.Id("save"));
        IWebElement userAndLoading => _driver.FindElement(By.Id("loading"));

        public GetRandomUserPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToGetNameUserPage()
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickGetNewUser()
        {
            getNewUserButton.Click();
        }

        internal void NewUserIsReturned()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(WebDriverHelper.TextToBePresentInElement(userAndLoading, "First Name :"));
            string name = userAndLoading.Text;
            string imageUrl = userAndLoading.FindElement(By.TagName("img")).GetAttribute("src");

            //TODO split name

            //TODO regex url
        }
    }
}
