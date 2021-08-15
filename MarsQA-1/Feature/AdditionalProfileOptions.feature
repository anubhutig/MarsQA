Feature: AdditionalProfileOptions
	I want to add additional details to my profile

@mytag
Scenario: Update your Name
	Given I am on Profile page
	And I click on my name
	And I Enter my First Name in textbox
	And I Enter my Last name in textbox
	When I click on save button
	Then Details should be saved

Scenario: Update your Availability
	Given I am on Profile page
	And I click on edit button next to Availability
	And I select a value from dropdown list
	Then Details should be saved

	Scenario: Update your Working Hours
	Given I am on Profile page
	And I click on edit button next to Hours
	And I select a value from dropdown list
	Then Details should be saved

	Scenario: Update Earn Target
	Given I am on Profile page
	And I click on edit button next to Earn Target
	And I select a value from dropdown list
	Then Details should be saved
