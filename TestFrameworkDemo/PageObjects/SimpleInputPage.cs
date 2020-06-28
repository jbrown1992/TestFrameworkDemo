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
        By enterValue1 => By.Id("sum1");
        By enterValue2 => By.Id("sum2");
        IWebElement getTotalButton => _driver.FindElements(By.ClassName("btn"))[1];
        IWebElement totalDisplayValue => _driver.FindElement(By.Id("displayvalue"));


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

        public void EnterAValue(string aValue)
        {
            _driver.FindElement(enterValue1).SendKeys(aValue);
        }

        public void TotalIsDisplayedCorrectly(string total)
        {
            Assert.AreEqual(total, totalDisplayValue.Text);
        }

        public void ClickGetTotal()
        {
            getTotalButton.Click();
        }

        public void EnterBValue(string bValue)
        {
            _driver.FindElement(enterValue2).SendKeys(bValue);
        }

        public void EnterMessageInToEnterMessageForm(string message)
        {
            _driver.FindElement(singleInputForm).FindElement(singleInputMessageInput).SendKeys(message);
        }
    }
}
