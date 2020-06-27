using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFrameworkDemo.Pages
{
    class HomePage
    {
        public readonly string url = "https://www.seleniumeasy.com/";

        public IWebElement btnDemoWebsite => btnDemoWebsite.FindElement(By.LinkText("Demo Website!"));
        public void ClickDemoWebsiteButton()
        {
            btnDemoWebsite.Click();
        }

    }
}
