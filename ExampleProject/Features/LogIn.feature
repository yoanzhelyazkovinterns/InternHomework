Feature: LogIn
	As a Registered User,
	I want to Log in Successfully

@positive
Scenario: Log in to Web Scraper website
	Given I navigate to Web Scraper home page
	When I enter "admin" in the username field
	And I enter "12345" in the password field
	And I click on Log in button
	Then I should see Welcome message
