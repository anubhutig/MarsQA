Feature: Skills
	I want to add skills in my profile

@mytag
Scenario: I want to add skills 
	Given I am on Profile page
	And I click on Skills Tab
	And I add Skill in Textbox
	And I choose skill level from dropdown list
	When I click on Add Button 
	Then the skill should be added

Scenario: I want to edit skills added earlier 
	Given I go to Profile page
	And I click on Skills Tab
	And I click on Edit Button next to the skill I want to edit
	And I replace Skill in Textbox
	And I choose skill level from dropdown list
	When I click on Uppdate Button 
	Then the skill should be Updated

	Scenario: I want to delete skills added earlier 
	Given I go to Profile page
	And I click on Skills Tab
	When I click on cross sign next to the skill I want to delete
	Then the skill should be deleted



