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
        IWebDriver _driver;
        string url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
        By headerFirstExample => By.ClassName("text-left");
        By singleInputForm => By.Id("get-input");
        By singleInputMessageInput => By.Id("user-message");
        By showMessageButton => By.ClassName("btn");
        By userMessage => By.Id("user-message");
        

        public SimpleInputPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void NavigateToSingleFormPage()
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void IsOnSingleInputPage()
        {
            Assert.AreEqual(url, _driver.Url);
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(WebDriverHelper.ElementIsDisplayed(headerFirstExample));
            Assert.IsTrue(_driver.FindElement(headerFirstExample).Text.Contains("first example"));
        }

        public void ClickShowMessage()
        {
            _driver.FindElement(singleInputForm).FindElement(showMessageButton).Click(); ;
        }

        public void MyMessageIsDisplayedAs(string message)
        {
            //Pad with space is not blank
            if (message.Length > 0)
            {
                message = " " + message;
            }
            var webElements = _driver.FindElements(userMessage);
            Assert.AreEqual(webElements[1].Text, $"Your Message:{message}");
        }

        public void EnterMessageInToEnterMessageForm(string message)
        {
            _driver.FindElement(singleInputForm).FindElement(singleInputMessageInput).SendKeys(message);
        }
    }
}
