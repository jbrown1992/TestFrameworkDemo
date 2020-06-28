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

Scenario: Checking all Checkboxes causes Uncheck all to be displayed
	Given I have navigated to Checkbox page
	When I click Checkbox 1
	And I click Checkbox 2
	And I click Checkbox 3
	And I click Checkbox 4
	Then Uncheck All is displayed

Scenario: Check All is displayed when at least once checkbox is unchecked
	Given I have navigated to Checkbox page
	When I click Checkbox 1
	And I click Checkbox 2
	And I click Checkbox 3
	Then Check All displayed

Scenario Outline: Check All is displayed when at least once checkbox is unchecked - List Solution
	Given I have navigated to Checkbox page
	When I click Checkboxes <checkBoxes>
	Then Check All displayed
	Examples: 
	| checkBoxes   |
	| 1            |
	| 1, 2, 3      |
	| 2, 3, 4      |

Scenario Outline: Uncheck All is displayed when all boxes are ticked - different orders
	Given I have navigated to Checkbox page
	When I click Checkboxes <checkBoxes>
	Then Uncheck All is displayed
	Examples: 
	| checkBoxes   |
	| 1, 2, 3, 4   |
	| 4, 3, 2, 1   |