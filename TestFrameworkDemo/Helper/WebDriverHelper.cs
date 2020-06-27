using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFrameworkDemo.Helper
{
    public class WebDriverHelper
    {
        public static void StaleElementHandleClick(IWebElement webElement)
        {
            int count = 0;
            bool clickSuccess = false;
            while (count < 4 && !clickSuccess)
                try
                {
                    webElement.Click();
                    clickSuccess = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Trying to recover from a stale element");
                    count++;
                }
        }
    }
}
