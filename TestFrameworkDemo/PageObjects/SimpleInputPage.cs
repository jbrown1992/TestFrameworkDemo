using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public IWebElement headerFirstExample => _driver.FindElement(By.CssSelector("col-md-6"));


        public SimpleInputPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void IsOnSingleInputPage()
        {
            Assert.AreEqual(url, _driver.Url);
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            wait.Until(Conditions.ElementIsVisible(headerFirstExample));
            Assert.IsTrue(headerFirstExample.Text.Contains("first example"));
        }

    }
}
