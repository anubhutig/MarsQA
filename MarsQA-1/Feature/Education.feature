Feature: Education
	I want to add my educational details to my profile

@mytag
Scenario Outline: 1 Add educational details in profile
    Given I am on Profile page
	And I click on Education Tab
	And I click on Add New Button to add education
	And I  pass < College > in textbox
	And I pass < Country > from dropdown where I did my Education
	And I pass < Title >from dropdown list
	And I pass < Degree > in field
	And I pass < GraduatedYear > from dropdown
	When I click on Add button
	Then My education details should be added
	Examples: 
	| College | Country   | Title         | Degree | GraduatedYear |
	| QUT     | Australia | B.Tech        | CS     | 1999            |
	| Tafe    | United States | M.Tech | CSE | 2010 |

	@tag4
	Scenario: 2 Edit educational details in profile
    Given I am on Profile page
	And I click on Education Tab
	And I click on Edit Button next to Educational details I want to edit
	And I provide new College/University Name in textbox
	And I provide new country from dropdown where I did my Education
	And I provide new Title from dropdown list
	And I provide new Degree in textbox
	And I provide new year of graduation from dropdown list
	When I click on Update button
	Then My education details should be updated

	@tag5
	Scenario: 3 Delete educational details in profile
    Given I am on Profile page
	And I click on Education Tab
	When I click on cross sign next to the educational details I want to delete
	Then the educational details should be deleted


	


	