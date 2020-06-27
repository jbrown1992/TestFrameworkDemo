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
        private HomePage _homePage;
        private DemoHomePage _demoHomePage;

        public DemoHomeSteps(HomePage homePage, DemoHomePage demoHomePage)
        {
            _homePage = homePage;
            _demoHomePage = demoHomePage;
        }

        [Given(@"I am on the Test Website")]
        public void GivenIAmOnTheTestWebsite()
        {
            _homePage.NavigateToHome();
        }
        
        [When(@"I click Demo Website Button")]
        public void WhenIClickDemoWebsiteButton()
        {
            _homePage.ClickDemoWebsiteButton();
        }

        [Then(@"I have navigated to the Demo Website")]
        public void ThenIHaveNavigatedToTheDemoWebsite()
        {
            _demoHomePage.IsOnDemoHomePage();
        }

    }
}
