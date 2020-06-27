using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFrameworkDemo.Helper
{
    public class WebDriverHelper
    {

        public static Func<IWebDriver, bool> ElementIsDisplayed(By locator)
        {
            return (driver) =>
            {
                try
                {
                    return driver.FindElement(locator).Displayed;
                }
                catch (Exception)
                {
                    // If element is null, stale or if it cannot be located
                    return false;
                }
            };
        }

        public static Func<IWebDriver, IWebElement> GetElementOnceVisible(By locator)
        {
            return (driver) =>
            {
                try
                {
                    if (driver.FindElement(locator).Displayed)
                        return driver.FindElement(locator);

                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    // If element is null, stale or if it cannot be located
                    return null;
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
