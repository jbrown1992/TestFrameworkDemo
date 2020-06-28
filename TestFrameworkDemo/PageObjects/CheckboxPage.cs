using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestFrameworkDemo.Helper;

namespace TestFrameworkDemo.PageObjects
{
    public class CheckboxPage
    {
        IWebDriver _driver;
        string url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
        By bySingleCheckboxDemoTitle => By.ClassName("panel-heading");
        IWebElement singleCheckoutDemoTitle => _driver.FindElements(bySingleCheckboxDemoTitle)[1];
        IWebElement singleCheckbox => _driver.FindElement(By.Id("isAgeSelected"));
        IWebElement successMessage => _driver.FindElement(By.Id("txtAge"));

        public CheckboxPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToCheckboxPage()
        {
            _driver.Navigate().GoToUrl(url);
        }

        internal void CheckboxMessageIsDisplayed()
        {
            var style = successMessage.GetAttribute("style");
            Assert.IsFalse(style.Contains("none"));
        }

        internal void CheckboxMessageIsNotDisplayed()
        {
            var style = successMessage.GetAttribute("style");
            Assert.IsTrue(style.Contains("none"));
        }

        internal void ClickSingleCheckbox()
        {
            singleCheckbox.Click();
        }

        public void IsOnCheckboxPage()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            Assert.IsTrue(wait.Until(WebDriverHelper.ElementIsDisplayed(bySingleCheckboxDemoTitle)));
            var expectedTitle = "Single Checkbox Demo";
            Assert.AreEqual(expectedTitle, singleCheckoutDemoTitle.Text);
        }
    }
}
