using System;
using TechTalk.SpecFlow;
using TestFrameworkDemo.Pages;

namespace TestFrameworkDemo
{
    [Binding]
    public class SimpleInputFormSteps
    {
        SimpleInputPage _simpleInputPage;

        public SimpleInputFormSteps(SimpleInputPage simpleInputPage)
        {
            _simpleInputPage = simpleInputPage;
        }
        [Given(@"I am on Simple Form Page")]
        public void GivenIAmOnSimpleFormPage()
        {
            _simpleInputPage.IsOnSingleInputPage();
        }

        [Given(@"I navigate to the Simple Form Page")]
        public void GivenINavigateToTheSimpleFormPage()
        {
            _simpleInputPage.NavigateToSingleFormPage();
        }


        [Given(@"I enter (.*) into Enter Message")]
        [When(@"I enter (.*) into Enter Message")]
        public void GivenIEnterIntoEnterMessage(string message)
        {
            _simpleInputPage.EnterMessageInToEnterMessageForm(message);
        }

        [Given, When(@"I click Show Message")]
        public void GivenIClickShowMessage()
        {
            _simpleInputPage.ClickShowMessage();
        }

        [Then(@"My message is displayed as (.*)")]
        public void ThenMyMessageIsDisplayedAs(string message)
        {
            _simpleInputPage.MyMessageIsDisplayedAs(message);
        }

        [Given(@"I enter (.*) into a")]
        [When(@"I enter (.*) into a")]
        public void WhenIEnterIntoA(string aValue)
        {
            _simpleInputPage.EnterAValue(aValue);
        }

        [Given(@"I enter (.*) into b")]
        [When(@"I enter (.*) into b")]
        public void WhenIEnterIntoB(string bValue)
        {
            _simpleInputPage.EnterBValue(bValue);
        }

        [When(@"I click Get Total")]
        public void WhenIClickGetTotal()
        {
            _simpleInputPage.ClickGetTotal();
        }

        [Then(@"My total is displayed as (.*)")]
        public void ThenMyTotalIsDisplayedAs(string total)
        {
            _simpleInputPage.TotalIsDisplayedCorrectly(total);
        }
    }
}
