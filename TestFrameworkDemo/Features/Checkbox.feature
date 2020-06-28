Feature: Checkbox
	As a tester
	I want to click checkboxes
	so I can practise by testing

Scenario: No message is displayed as default
	Given I have navigated to Checkbox page
	Then Checkbox success message is not displayed

Scenario: Clicking Checkbox displays message
	Given I have navigated to Checkbox page
	When I click single Checkbox
	Then Checkbox success message is displayed

Scenario: Toggle Checkbox displayed expected message - On to Off
	Given I have navigated to Checkbox page
	When I click single Checkbox
	And I click single Checkbox
	Then Checkbox success message is not displayed

Scenario: Toggle Checkbox displayed expected message - Off to On
	Given I have navigated to Checkbox page
	When I click single Checkbox
	And I click single Checkbox
	And I click single Checkbox
	Then Checkbox success message is displayed