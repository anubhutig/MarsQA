Feature: Certificates
	I want to add certificates or awards to my profile

@mytaga
Scenario Outline: 1 Add certificates or awards to my profile
	Given I login to the website  
	Given I am on Profile page
	And I click on Certificates Tab
	And I click on Add New Button
	And I input < Award > in textbox
	And I type < Certifier > in box
	And I select < Year > from dropdown list
	When I click on Add button to add certificate
	Then My certificate details should be added
	Examples:
	| Award | Certifier | Year |
	| Scrum Master| ScrumStudy | 2010 |
	| Project Managment | QUT | 2020 |
	| Test Analyst | Industry Connect | 2012 |

Scenario: 2 Edit certificates or awards to my profile
    Given I login to the website  
	Given I am on Profile page
	And I click on Certificates Tab
	And I click on Edit Button next to Certificate details I want to edit
	And I update new Certificates or Award in textbox
	And I update new Certifier's Name in textbox
	And I update new Year from dropdown list
	When I click on Update button to update certificate
	Then My certificate details should be updated

	Scenario: 3 Delete certificates or awards to my profile
	Given I login to the website  
	Given I am on Profile page
	And I click on Certificates Tab
	When I click on Delete Button next to Certificate details I want to delete
	Then the Certificate details should be deleted
