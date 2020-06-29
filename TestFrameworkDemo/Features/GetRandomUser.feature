Feature: Get Random User
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Get Random User
	Given I navigate to the Get Random User page
	When I click Get New User
	
	Then New User is returned
	# Picture
	# First name
	# Last name

Scenario: Loading is displayed before new user is returned
	Given I navigate to the Get Random User page
	When I click Get New User
	Then Loading icon is displayed until New Usser is returned
