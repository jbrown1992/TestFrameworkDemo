using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TestFrameworkDemo.Pages
{
    public class DemoHomePage
    {
        private IWebDriver _driver;
        private string url = "https://www.seleniumeasy.com/test/";
        public IWebElement btnDemoHome => _driver.FindElement(By.LinkText("Demo Home"));
        public IWebElement btnStartPractising => _driver.FindElement(By.Id("btn_basic_example"));

        public DemoHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickStartPractising()
        {
            btnStartPractising.Click();
        }

        public void IsOnDemoHomePage()
        {
            Assert.IsTrue(btnStartPractising.Displayed);
        }

        public void NavigateToDemoHomePage()
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
