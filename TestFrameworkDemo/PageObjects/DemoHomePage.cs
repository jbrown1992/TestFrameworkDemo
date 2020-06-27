using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Nest;
using OpenQA.Selenium.Support.UI;
using TestFrameworkDemo.Helper;

namespace TestFrameworkDemo.Pages
{
    public class DemoHomePage
    {
        private IWebDriver _driver;
        private string url = "https://www.seleniumeasy.com/test/";
        public IWebElement btnDemoHome => _driver.FindElement(By.LinkText("Demo Home"));
        public IWebElement btnStartPractising => _driver.FindElement(By.Id("btn_basic_example"));

        public IWebElement toggleBasic => _driver.FindElement(By.Id("basic_example"));
        public IWebElement paneBasic => _driver.FindElement(By.Id("basic"));


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

        public void BasicIsDislayed()
        {
            //Basic Examples is expanded
            Assert.AreEqual("true", toggleBasic.GetAttribute("aria-expanded"));

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            wait.Until(Conditions.ElementIsVisible(paneBasic));

            //Header is correct
            Assert.AreEqual("BASIC EXAMPLES TO START WITH SELENIUM", paneBasic.FindElement(By.ClassName("head")).Text);

            //Practise components are displayed as expected
            var demoComponents = paneBasic.FindElements(By.ClassName("list-group-item"));
            var expectedComponents = new List<string> { "Simple Form Demo", "Check Box Demo", "Radio Buttons Demo", "Select Dropdown List", "Javascript Alerts", "Window Popup Modal", "Bootstrap Alerts", "Bootstrap Modals" };
            var actualComponents = new List<string>();

            foreach (var item in demoComponents)
            {
                var text = item.Text;
                actualComponents.Add(text);
            }

            Assert.AreEqual(expectedComponents, actualComponents);
    }

    }
}














