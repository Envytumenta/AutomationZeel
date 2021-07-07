Feature: Login
	Payroll login

@PayrollLOgin
Scenario: Valid payroll login
	Given I am on theb website
	And I enter my username 
	And I enter my password
	When I click on the login button
	Then I should be logged in





#
#	@PayrollLOgin
#Scenario: InValid payroll login
#	Given I am on theb website
#	And I enter my username 'Automation Tester'
#	And I enter my invalid password 'Zeel'
#	When I click on the login button
#	Then I should not be logged in
