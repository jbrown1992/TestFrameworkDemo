using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TestFrameworkDemo.PageObjects;

namespace TestFrameworkDemo.Steps
{
    [Binding]
    public class GetRandomUserSteps
    {
        GetRandomUserPage _getRandomUserPage;

        public GetRandomUserSteps(GetRandomUserPage getRandomUserPage)
        {
            _getRandomUserPage = getRandomUserPage;
        }
        [Given(@"I navigate to the Get Random User page")]
        public void GivenINavigateToTheGetRandomUserPage()
        {
            _getRandomUserPage.NavigateToGetNameUserPage();
        }

        [When(@"I click Get New User")]
        public void WhenIClickGetNewUser()
        {
            _getRandomUserPage.ClickGetNewUser();
        }

        [Then(@"New User is returned")]
        public void ThenNewUserIsReturned()
        {
            _getRandomUserPage.NewUserIsReturned();
        }

        [Then(@"Loading icon is displayed until New User is returned")]
        public void ThenLoadingIconIsDisplayedUntilNewUserIsReturned()
        {
            _getRandomUserPage.LoadingIconIsDisplayed();
        }

    }
}
