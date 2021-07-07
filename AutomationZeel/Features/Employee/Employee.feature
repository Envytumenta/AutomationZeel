Feature: Employee
	Testing how to add a new employee

@AddNewEmployee
Scenario: Varify all mandetory fields in add new employee general details page can accept inputs
	Given I am on the website
	And I enter my username 'Automation Tester'
	And I enter my password 'Arsenal1'
	And I click on the login button
	And I click on employee
	And I click on add new
	And I input RTI Reference '11111'
	And I input employment type 'Umbrella'
	And I input employment start date '01/01/1999'
	And I input payroll reference '1222'
	And I input payment methods 'Cheque'
	And I input employee type 'Temporary'
	And I select gender 'Male'
	And I select title 'Mr'
	And I select payment frequency 'Weekly'
	And I input first name 'TestQ'
	And I input last name 'TestQ'
	And I input date of birth '01/01/1980'
	And I input age '41'
	And I input payslip methods 'Print'
	When I click on the next button
	Then contact details page should be displayed





	Scenario: Varify all mandetory fields in add new employee contact details page can accept inputs
	Given I am on the website
	And I enter my username 'Automation Tester'
	And I enter my password 'Arsenal1'
	And I click on the login button
	And I click on employee
	And I click on add new
	And I enter address line one '280 hordern road'
	And I enter address line two '290 hordern road'
	And I choose a country 'United Kingdom'
	And I choose a county 'west midlands'
	And I choose a city 'Wolverhampton'
	And I enter postcode 'Wv60he'
	And I enter email address 'mantiti@mail.com'
	When I click on the next button
	Then bank details page should be displayed






	Scenario: Varify all mandetory fields in add new employee bank details page can accept inputs
	Given I am on the website
	And I enter my username 'Automation Tester'
	And I enter my password 'Arsenal1'
	And I click on the login button
	And I click on employee
	And I click on add new
	And I input my bank name 'People Bank'
	And I input my sort code '141414'
	And I input my building society roll number'1234'
	And I input my swift code 'Gb123456789'
	And I input my account name 'TestQ TestQ'
	And O input my account number '99999999'
	And I input my IBAN number '1234567890'
	And I input my address line one '280 hordern road'
	And I input my address line two '290 hordern road'
	And I choose my country 'United Kingdom'
	And I choose my county 'West Midlands'
	And I choose my city 'Wolverhampton'
	And I enter my postcode 'wv60he'
	And I enter my phone number '01902444441'
	And I enter my fax number '343434'
	When I click on the next button
	Then employment details page should be displayed






	Scenario: Varify all mandetory fields in add new employee employment details page can accept inputs
	Given I am on the website
	And I enter my username 'Automation Tester'
	And I enter my password 'Arsenal1'
	And I click on the login button
	And I click on employee
	And I click on add new
	And I select employment statement ' This is my only job'
	And I enter my tax code '1250L'
	And I input week1/month1 'yes'
	And I select student loan 'No'
	And I select postgraduate student loan '
	And I select start date '06/07/2021'
	And I select NI letter 'standard rate'
	And I input my NI number'AB123007C'
	And I select pay plan 'PGSL'
	And I input end date '06/07/2030'
	When I click on the next button
	Then pension details page should be displayed





	Scenario: Varify all mandetory fields in add new employees pension details page can accept inputs
	Given I am on the website
	And I enter my username 'Automation Tester'
	And I enter my password 'Arsenal1'
	And I click on the login button
	And I click on employee
	And I click on add new
	And I select scheme and imput 'AE No Tax relief'
	And I imput employee contribution '6.00'
	And I input Opt in 'No'
	And I input postpone 'No'
	And I input cease membership 'No'
	And I input date  joined '06/07/20201'
	When I click on the next button
	Then bank details page should be displayed




	Scenario: Varify all mandetory fields in add new employee banking details page can accept inputs
	Given I am on the website
	And I enter my username 'Automation Tester'
	And I enter my password 'Arsenal1'
	And I click on the login button
	And I click on employee
	And I click on add new
	And I input working pattern 'Fixed WorkingDays(Fixed Pay)'
	And I input pay rate '9.00'
	And I select monday
	And I select tuesday
	And I select wednesday
	And I select thursday
	And I select friday
	And I click on the next button
	When I click on complete
	Then employee should be created and the general details page displayed









