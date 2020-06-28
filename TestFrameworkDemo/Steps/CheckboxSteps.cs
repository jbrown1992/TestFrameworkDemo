using System;
using System.Collections.Generic;
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

        [When(@"I click Checkbox 1")]
        public void WhenIClickCheckbox1()
        {
            _checkboxPage.ClickMultipleCheckbox(1);
        }

        [When(@"I click Checkbox 2")]
        public void WhenIClickCheckbox2()
        {
            _checkboxPage.ClickMultipleCheckbox(2);
        }

        [When(@"I click Checkbox 3")]
        public void WhenIClickCheckbox3()
        {
            _checkboxPage.ClickMultipleCheckbox(3);
        }

        [When(@"I click Checkbox 4")]
        public void WhenIClickCheckbox4()
        {
            _checkboxPage.ClickMultipleCheckbox(4);
        }

        [Then(@"Uncheck All is displayed")]
        public void ThenUncheckAllIsDisplayed()
        {
            _checkboxPage.UncheckAllIsDisplayed();
        }

        [Then(@"Check All displayed")]
        public void ThenCheckAllDisplayed()
        {
            _checkboxPage.CheckAllIsDisplayed();
        }

        [When(@"I click Checkboxes (.*)")]
        public void WhenIClickCheckboxes(string numberOfCheckboxes)
        {
            //Move to method!
            if (numberOfCheckboxes.Contains(","))
            {
                foreach (var checkBoxNumber in numberOfCheckboxes.Split(","))
                {
                    _checkboxPage.ClickMultipleCheckbox(Int32.Parse(checkBoxNumber));
                }
            }

            else
            {
                _checkboxPage.ClickMultipleCheckbox(Int32.Parse(numberOfCheckboxes));
            }
        }






    }
}
