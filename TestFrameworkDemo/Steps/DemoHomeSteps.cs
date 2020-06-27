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
        private SimpleInputPage _simpleInputPage;

        public DemoHomeSteps(HomePage homePage, DemoHomePage demoHomePage, SimpleInputPage simpleInputPage)
        {
            _homePage = homePage;
            _demoHomePage = demoHomePage;
            _simpleInputPage = simpleInputPage;
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

        [Given(@"I am on the Demo Home Page")]
        public void GivenIAmOnTheDemoHomePage()
        {
            _demoHomePage.NavigateToDemoHomePage();
        }

        [Given(@"I click Start Practising Button")]
        [When(@"I click Start Practising Button")]
        public void WhenIClickStartPractisingButton()
        {
            _demoHomePage.ClickStartPractising();
        }

        [Then(@"Basic examples are displayed")]
        public void ThenBasicExamplesAreDisplayed()
        {
            _demoHomePage.BasicIsDislayed();
        }

        [When(@"I click Simple Form Demo")]
        public void WhenIClickSimpleFormDemo()
        {
            _demoHomePage.ClickSimpleFormDemo();
        }

        [Then(@"I have navigated to Simple Form Demo Page")]
        public void ThenIHaveNavigatedToSimpleFormDemoPage()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
