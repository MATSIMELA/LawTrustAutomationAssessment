Feature: Registrations
As a user I should be able to register

@smoke @regression 
Scenario: Successfull  Registration
      #Steps
	Given "Login" Page is displayed
	And I click "Sign Up" button
	And "Registration" page is displayed
	And I enter the following details
		| Name  | Email            | MobileNumber | JobTitle                  | CompanyName | TermsAndConditions |
		| Jerry | Test12@gmail.com | 012345       | Software Quality Engineer | LawTrust      | Accept             |
	When I click "Next" button
	Then I expect to see title "