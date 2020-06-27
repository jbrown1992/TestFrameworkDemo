using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TestFrameworkDemo.Pages
{
    public class DemoHomePage
    {
        public IWebDriver WebDriver { get; }
        public IWebElement btnDemoHome => WebDriver.FindElement(By.LinkText("Demo Home"));
        public IWebElement btnStartPractising => WebDriver.FindElement(By.Id("btn_basic_example"));
   
        public void ClickStartPractising()
        {
            btnStartPractising.Click();
        }

        public void IsOnDemoHomePage()
        {
            Assert.IsTrue(btnStartPractising.Displayed);
        }
    }
}
