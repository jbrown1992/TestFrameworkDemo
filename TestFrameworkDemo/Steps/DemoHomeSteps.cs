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

        [Given(@"I am on the Test Website")]
        public void GivenIAmOnTheTestWebsite()
        {

        }
        
        [When(@"I click Demo Website Button")]
        public void WhenIClickDemoWebsiteButton()
        {

        }
        
        [Then(@"I navigate to the Demo Website")]
        public void ThenINavigateToTheDemoWebsite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
