using System;
using TechTalk.SpecFlow;
using TestFrameworkDemo.PageObjects;

namespace TestFrameworkDemo.Steps
{
    [Binding]
    public class CheckboxSteps
    {
        CheckboxPage _checkboxPage;
        public CheckboxSteps(CheckboxPage checkboxPage)
        {
            _checkboxPage = checkboxPage;
        }
        [Given(@"I have navigated to Checkbox page")]
        public void GivenIHaveNavigatedToCheckboxPage()
        {
            _checkboxPage.NavigateToCheckboxPage();
            _checkboxPage.IsOnCheckboxPage();
        }

        [When(@"I click single Checkbox")]
        public void WhenIClickSingleCheckbox()
        {
            _checkboxPage.ClickSingleCheckbox();
        }

        [Then(@"Checkbox success message is displayed")]
        public void ThenCheckboxSuccessMessageIsDisplayed()
        {
            _checkboxPage.CheckboxMessageIsDisplayed();
        }

        [Then(@"Checkbox success message is not displayed")]
        public void ThenCheckboxSuccessMessageIsNotDisplayed()
        {
            _checkboxPage.CheckboxMessageIsNotDisplayed();
        }



    }
}
