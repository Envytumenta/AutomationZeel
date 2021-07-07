using AutomationZeel.Hooks;
using AutomationZeel.PageObject.Employee;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationZeel.Features.Employee
{
    [Binding]
    public class EmployeeSteps
    {

        public IWebDriver driver = WebHook.driver;

        EmployeePage employeePage = new EmployeePage();

        [Given(@"I am on the website")]
        public void GivenIAmOnTheWebsite()
        {
            driver.Navigate().GoToUrl("http://zrecruiterlocal/ZPQADev2017/Pages/Login.aspx?t=s");
        }

        [Given(@"I enter my username '(.*)'")]
        public void GivenIEnterMyUsername(string UserNameData)
        {
            employeePage.UserName(UserNameData);
        }

        [Given(@"I enter my password '(.*)'")]
        public void GivenIEnterMyPassword(string PasswordData)
        {
            employeePage.Password(PasswordData);
        }

        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            employeePage.Login();
        }

        [Given(@"I click on employee")]
        public void GivenIClickOnEmployee()
        {
            employeePage.ClickEmployeeButton();
        }

        [Given(@"I click on add new")]
        public void GivenIClickOnAddNew()
        {
            employeePage.ClickAddNewButton();
        }

        [Given(@"I input RTI Reference '(.*)'")]
        public void GivenIInputRTIReference(string RTIData)
        {
            employeePage.RTIReference(RTIData);
        }

        [Given(@"I input employment type '(.*)'")]
        public void GivenIInputEmploymentType(string EmploymentTypeData)
        {
            employeePage.EmploymentType(EmploymentTypeData);
        }

        [Given(@"I input employment start date '(.*)'")]
        public void GivenIInputEmploymentStartDate(string StartDateData)
        {
            employeePage.EmploymentStartDate(StartDateData);
        }

        [Given(@"I input payroll reference '(.*)'")]
        public void GivenIInputPayrollReference(string PayrollData)
        {
            employeePage.PayrollReference(PayrollData);
        }

        [Given(@"I input payment methods '(.*)'")]
        public void GivenIInputPaymentMethods(string PaymentData)
        {
            employeePage.MethodsP(PaymentData);
        }
        [Given(@"I input employee type '(.*)'")]
        public void GivenIInputEmployeeType(string TypeData)
        {
            employeePage.EmployeeType(TypeData);
        }


        [Given(@"I select gender '(.*)'")]
        public void GivenISelectGender(string GenderData)
        {
            employeePage.Gender(GenderData);
        }

        [Given(@"I select title '(.*)'")]
        public void GivenISelectTitle(string TitleData)
        {
            employeePage.Title(TitleData);
        }

        [Given(@"I select payment frequency '(.*)'")]
        public void GivenISelectPaymentFrequency(string FrequencyData)
        {
            employeePage.PaymentFrequency(FrequencyData);
        }

        [Given(@"I input first name '(.*)'")]
        public void GivenIInputFirstName(string FirstData)
        {
            employeePage.FirstName(FirstData);
        }

        [Given(@"I input last name '(.*)'")]
        public void GivenIInputLastName(string LastData)
        {
            employeePage.LastName(LastData);
        }

        [Given(@"I imput date of birth '(.*)'")]
        public void GivenIImputDateOfBirth(string BirthData)
        {
            employeePage.DateOfBirth(BirthData);
        }

        [Given(@"I input age '(.*)'")]
        public void GivenIInputAge(string AgeData)
        {
            employeePage.Age(AgeData);
        }

        [Given(@"I input payslip methods '(.*)'")]
        public void GivenIInputPayslipMethods(string PayslipData)
        {
            employeePage.PayslipMethods(PayslipData);
        }

        [When(@"I click on the next button")]
        public void WhenIClickOnTheNextButton()
        {
            employeePage.NextButton();
        }

        [Then(@"contact details page should be displayed")]
        public void ThenContactDetailsPageShouldBeDisplayed()
        {
            
        }
    }
}
