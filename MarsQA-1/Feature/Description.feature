Feature: Description
	I want to add description in my profile

@mytag
Scenario: Add description
	Given I am on Profile Page
	And I click on Add Description
	And I input Description in textbox
	When I click on Save Button 
	Then The description should be saved