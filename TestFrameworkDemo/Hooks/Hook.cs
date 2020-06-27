using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestFrameworkDemo.Hooks
{
    [Binding]
    public sealed class Hook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: fix path
            //TODO: driver singleton
            driver = new ChromeDriver("C:\\Users\\james\\source\\repos\\TestFrameworkDemo\\TestFrameworkDemo\\bin\\Debug\\netcoreapp3.1");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
