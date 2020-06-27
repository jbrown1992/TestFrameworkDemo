using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace TestFrameworkDemo
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer objectContainer;

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var webDriver = new ChromeDriver("C:\\Users\\james\\source\\repos\\TestFrameworkDemo\\TestFrameworkDemo\\bin\\Debug\\netcoreapp3.1");
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }
    }
}
