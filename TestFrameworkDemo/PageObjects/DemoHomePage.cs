using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Nest;
using OpenQA.Selenium.Support.UI;
using TestFrameworkDemo.Helper;
using SeleniumExtras.WaitHelpers;

namespace TestFrameworkDemo.Pages
{
    public class DemoHomePage
    {
        private IWebDriver _driver;
        private string url = "https://www.seleniumeasy.com/test/";
        private By btnDemoHome => By.LinkText("Demo Home");
        private By btnStartPractising => By.Id("btn_basic_example");
        private By toggleBasic => By.Id("basic_example");
        private By paneBasic => By.Id("basic");
        private By simpleFormDemoLink => By.LinkText("Simple Form Demo");
        private By btnPopUpClose => By.Id("at-cv-lightbox-close");
        //at-cv-lightbox-close

        public DemoHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickStartPractising()
        {
            _driver.FindElement(btnStartPractising).Click();
        }

        public void IsOnDemoHomePage()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            Assert.IsTrue(wait.Until(WebDriverHelper.ElementIsDisplayed(btnStartPractising)));
        }

        public void NavigateToDemoHomePage()
        {
            _driver.Navigate().GoToUrl(url);
            Assert.IsTrue(_driver.FindElement(btnStartPractising).Displayed);
            if (IsPopUpClickNeeded())
                _driver.FindElement(btnPopUpClose).Click();
        }

        public void BasicIsDislayed()
        {
            //Basic Examples is expanded
            Assert.AreEqual("true", _driver.FindElement(toggleBasic).GetAttribute("aria-expanded"));

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(WebDriverHelper.GetElementOnceVisible(paneBasic));

            //Header is correct
            Assert.AreEqual("BASIC EXAMPLES TO START WITH SELENIUM", element.FindElement(By.ClassName("head")).Text);

            //Practise components are displayed as expected
            var demoComponents = element.FindElements(By.ClassName("list-group-item"));
            var expectedComponents = new List<string> { "Simple Form Demo", "Check Box Demo", "Radio Buttons Demo", "Select Dropdown List", "Javascript Alerts", "Window Popup Modal", "Bootstrap Alerts", "Bootstrap Modals" };
            var actualComponents = new List<string>();

            foreach (var item in demoComponents)
            {
                var text = item.Text;
                actualComponents.Add(text);
            }

            Assert.AreEqual(expectedComponents, actualComponents);
        }

        public void ClickSimpleFormDemo()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            wait.Until(WebDriverHelper.ElementIsDisplayed(paneBasic));
            WebDriverHelper.StaleElementHandleClick(_driver.FindElement(simpleFormDemoLink));
        }

        private bool IsPopUpClickNeeded()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));

            try
            {
                wait.Until(WebDriverHelper.ElementIsDisplayed(btnPopUpClose));
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("No popup to click...test continuing");
                return false;
            }
        }

    }
}














