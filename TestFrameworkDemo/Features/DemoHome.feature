Feature: Demo Home
	As a tester
	I want to navigate to the demo page
	So I can see what I can practise
	
Scenario: Navigate to Demo Home
	Given I am on the Test Website
	When I click Demo Website Button
	Then I have navigated to the Demo Website

Scenario: Navigate to Basic Examples
	Given I am on the Demo Home Page
	When I click Start Practising Button
	Then Basic examples are displayed

Scenario: Navigate to Simple Form Demo
	Given I am on the Demo Home Page
	And I click Start Practising Button
	When I click Simple Form Demo
	Then I have navigated to Simple Form Demo Page