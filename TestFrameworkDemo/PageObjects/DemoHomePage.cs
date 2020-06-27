using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestFrameworkDemo.Hooks;

namespace TestFrameworkDemo.Pages
{
    public class DemoHomePage
    {
        IWebDriver driver;

        public DemoHomePage()
        {
            driver = Hook.driver;
        }

        public IWebElement btnDemoHome => driver.FindElement(By.LinkText("Demo Home"));
        public IWebElement btnStartPractising => driver.FindElement(By.Id("btn_basic_example"));
   
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
