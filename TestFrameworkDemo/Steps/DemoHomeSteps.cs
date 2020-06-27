using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestFrameworkDemo.Pages;

namespace TestFrameworkDemo.Steps
{
    [Binding]
    public class DemoHomeSteps
    {
        HomePage homePage = new HomePage();

        [Given(@"I am on the Test Website")]
        public void GivenIAmOnTheTestWebsite()
        {
            homePage.NavigateToHome();
        }
        
        [When(@"I click Demo Website Button")]
        public void WhenIClickDemoWebsiteButton()
        {
            homePage.ClickDemoWebsiteButton();
        }

        [Then(@"I have navigated to the Demo Website")]
        public void ThenIHaveNavigatedToTheDemoWebsite()
        {
            DemoHomePage demoHomePage = new DemoHomePage();
            demoHomePage.IsOnDemoHomePage();
        }

    }
}
