using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TestFrameworkDemo.Helper;

namespace TestFrameworkDemo.Pages
{
    public class SimpleInputPage
    {
        private IWebDriver _driver;
        private string url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
        public By headerFirstExample => By.ClassName("text-left");


        public SimpleInputPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void IsOnSingleInputPage()
        {
            Assert.AreEqual(url, _driver.Url);
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(headerFirstExample));
            Assert.IsTrue(_driver.FindElement(headerFirstExample).Text.Contains("first example"));
        }

    }
}
