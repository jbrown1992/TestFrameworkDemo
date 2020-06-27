using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFrameworkDemo.Helper
{
    public class Conditions
    {

        public static Func<IWebDriver, bool> ElementIsVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception)
                {
                    // If element is null, stale or if it cannot be located
                    return false;
                }
            };
        }

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
