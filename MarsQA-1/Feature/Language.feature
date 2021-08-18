Feature: Language
	I am on profile page and I want to add languages I know 

@mytag
Scenario Outline: 1 Add Languages to your profile
	Given I login to the website  
	Given I am on Profile Page
	And I click on Add New Button in Languages Tab
	And I add <language> in textbox
	And I choose a <Level> for language from dropdown list
	When I click on Add Button
	Then The language should be added to my profile
	Examples:
	| language | Level          |
	| English  | Conversational |
	| Hindi    | Fluent         |
	| French   | Basic          |
	| German   | Basic          |

	


	@mytag1
	Scenario: 2 Edit the Language added earlier
	Given I login to the website  
	Given I am on Profile Page
	And I click on Edit Button next to language I want to edit
	And I replace old input in textbox with new language
	And I replace old input in dropdown list with new level
	When I click on Update Button
	Then the language should be updated

	@mytag2
	  
	Scenario: 3 Delete the language added earlier
	Given I login to the website
	Given I am on Profile Page
	When I click on cross sign next to the language I want to delete
	Then the language should be deleted