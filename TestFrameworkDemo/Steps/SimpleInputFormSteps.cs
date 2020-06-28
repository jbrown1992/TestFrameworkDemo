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
        
        [Given(@"I click Show Message")]
        [When(@"I click Show Message")]
        public void GivenIClickShowMessage()
        {
            _simpleInputPage.ClickShowMessage();
        }

        [Then(@"My message is displayed as (.*)")]
        public void ThenMyMessageIsDisplayedAs(string message)
        {
            _simpleInputPage.MyMessageIsDisplayedAs(message);
        }
    }
}
