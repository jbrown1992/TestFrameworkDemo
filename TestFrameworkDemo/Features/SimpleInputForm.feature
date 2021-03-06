﻿Feature: SimpleInputForm
	As a tester
	I want enter values into forms
	So I can see my values

	@singleInputField
Scenario Outline: Enter Message into Single Input Field
	Given I navigate to the Simple Form Page
	When I enter <message> into Enter Message
	And I click Show Message
	Then My message is displayed as <message>
	Examples: 
		| message     |
		|             |
		| hello       |
		| hello world |
		| Hello World |
		| He110 W@RlD |

	@singleInputField
Scenario: Message is Updated on Single Input Field
	Given I navigate to the Simple Form Page
	And I enter Hello into Enter Message
	And I click Show Message
	When I enter World into Enter Message 
	And I click Show Message
	Then My message is displayed as HelloWorld

	@twoInputField
Scenario Outline: Enter Values into Two Input Fields
	Given I navigate to the Simple Form Page
	When I enter <aValue> into a
	And I enter <bValue> into b
	And I click Get Total
	Then My total is displayed as <total>
	Examples: 
		| aValue                | bValue                | total     |
		| 1                     | 1                     | 2         |
		| 999999999999999999999 | 999999999999999999999 | 2e+21     |
		| 563563563             | 234234243             | 797797806 |
		| 0                     | 1                     | 1         |
		| 10                    | 23                    | 33        |
		| 10                    | -5                    | 5         |
		|                       |                       | NaN       |
		| 1                     |                       | NaN       |
		|                       | 1                     | NaN       |
		| A                     | 10                    | NaN       |
		| 19                    | B                     | NaN       |