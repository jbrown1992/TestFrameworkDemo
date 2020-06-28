using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestFrameworkDemo.Hooks
{
    [Binding]
    public class Hook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private static IWebDriver _driver;

        public Hook(IWebDriver driver)
        {
            _driver = driver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        { 

        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
