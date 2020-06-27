using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestFrameworkDemo.Hooks;

namespace TestFrameworkDemo.Pages
{
    class HomePage
    {

        IWebDriver driver;


        public HomePage()
        {
            driver = Hook.driver;
        }

        private string url = "https://www.seleniumeasy.com/";

        public IWebElement btnDemoWebsite => driver.FindElement(By.LinkText("Demo Website!"));
        public void ClickDemoWebsiteButton()
        {
           btnDemoWebsite.Click();
        }

        public void NavigateToHome()
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
