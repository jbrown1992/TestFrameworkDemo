using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFrameworkDemo.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;
        private string url = "https://www.seleniumeasy.com/";
        public IWebElement btnDemoWebsite => _driver.FindElement(By.LinkText("Demo Website!"));


        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickDemoWebsiteButton()
        {
           btnDemoWebsite.Click();
        }

        public void NavigateToHome()
        {
            _driver.Navigate().GoToUrl(url);
        }

    }
}
