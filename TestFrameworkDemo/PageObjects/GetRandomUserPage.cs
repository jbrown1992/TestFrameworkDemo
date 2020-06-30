using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TestFrameworkDemo.Helper;

namespace TestFrameworkDemo.PageObjects
{
    public class GetRandomUserPage
    {
        IWebDriver _driver;
        string url = "https://www.seleniumeasy.com/test/dynamic-data-loading-demo.html";
        IWebElement getNewUserButton => _driver.FindElement(By.Id("save"));
        IWebElement userAndLoading => _driver.FindElement(By.Id("loading"));

        public GetRandomUserPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToGetNameUserPage()
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickGetNewUser()
        {
            getNewUserButton.Click();
        }

        internal void NewUserIsReturned()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(WebDriverHelper.TextToBePresentInElement(userAndLoading, "First Name :"));
            string name = userAndLoading.Text;

            //TODO split name
            string[] nameArray = name.Replace("\r\n\r\n", "|").Split('|');

            //'FirstName : ' is present 
            Assert.AreEqual("First Name : ", nameArray[0].Substring(0, 13));
            Assert.AreEqual("Last Name : ", nameArray[1].Substring(0, 12));

            string firstName = nameArray[0].Substring(13, nameArray[0].Length - 13);
            string lastName = nameArray[1].Substring(12, nameArray[1].Length - 12);

            IsNameInCorrectFormat(firstName);
            IsNameInCorrectFormat(lastName);

            //TODO regex url
            string imageUrl = userAndLoading.FindElement(By.TagName("img")).GetAttribute("src");
            Assert.AreEqual("https://randomuser.me/api/portraits/", imageUrl.Substring(0, 36));
            Assert.AreEqual(".jpg", imageUrl.Substring(imageUrl.Length-4, 4));

        }

        internal void LoadingIconIsDisplayed()
        {
            Assert.AreEqual("loading...", userAndLoading.Text);
        }

        private void IsNameInCorrectFormat(string name)
        {
            char[] nameChar = name.ToCharArray();
            Assert.IsTrue(Char.IsUpper(nameChar[0]));
            foreach (var letter in nameChar)
            {
                Assert.IsTrue(Regex.IsMatch(letter.ToString(), @"^[a-zA-Z]+$"));
            }

        }
    }
}
