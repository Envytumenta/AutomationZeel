using AutomationZeel.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationZeel.PageObject.Employee
{
    class EmployeePage
    {
        public IWebDriver driver;

        public EmployeePage()
        {
            driver = WebHook.driver;
        }


        private By username = By.Id("body_tbUsername");
        private By password = By.Id("body_tbPassword");
        private By login = By.Id("body_btnLogin");
        private By employee = By.XPath("//*[@id='m4'']/div/span");
        private By addNew = By.XPath("//*[@id='m4'']/ul/li[1]/div");
        private By rTIReference = By.Id("body_GeneralDetails_txtRTIRef");
        private By employmentType = By.XPath("//*[@id='bodyGeneralDetailsddlEmpTypechosen']/a/span");
        private By employmentStartDate = By.Id("txtEmploymentStartDate");
        private By payrollReference = By.Id("body_GeneralDetails_txtPayRef");
        private By methodsP = By.XPath("//*[@id='bodyGeneralDetailsddlPayTypechosen'']/div/div/input");
        private By employeeType = By.XPath("//*[@id='bodyGeneralDetailsddlWorkerTypechosen'']/div/div/input");
        private By gender = By.XPath("//*[@id='bodyGeneralDetailsddlGenderchosen'']/div/div/input");
        private By title = By.XPath("//*[@id='bodyGeneralDetailsddlTitlechosen']/div/div/input");
        private By paymentFrequency = By.XPath("//*[@id='ddlPayFreqchosen'']/div/div/input");
        private By firstName = By.Id("txtFirstName");
        private By lastName = By.Id("txtLastName");
        private By dateOfBirth = By.XPath("//*[@id='bodyGeneralDetailstxtDOB'']");
        private By age = By.Id("body_GeneralDetails_txtAge");
        private By payslipMethods = By.XPath("//*[@id='bodyGeneralDetailslstPayslipMethodchosen'']/div/div/input");
        private By nextButton = By.ClassName("wizard-next");



        public void UserName(string UserNameData)
        {
            driver.FindElement(username).SendKeys(UserNameData);
        }

        public void Password(string PasswordData)
        {
            driver.FindElement(password).SendKeys(PasswordData);
        }
        public void Login()
        {
            driver.FindElement(login).Click();
        }

        public void ClickEmployeeButton()
        {
            Thread.Sleep(5000);
            driver.FindElement(employee).Click();
        }

        public void ClickAddNewButton()
        {
            Thread.Sleep(5000);
            driver.FindElement(addNew).Click();
        }

        public void RTIReference(string RTIData)
        {
            driver.FindElement(rTIReference).SendKeys(RTIData);
            Thread.Sleep(3000);
        }

        public void EmploymentType(string EmploymentTypeData)
        {
            driver.FindElement(employmentType).SendKeys(EmploymentTypeData);
        }

        public void EmploymentStartDate(string StartDateData)
        {
            driver.FindElement(employmentStartDate).SendKeys(StartDateData);
        }

        public void PayrollReference(string PayrollData)
        {
            driver.FindElement(payrollReference).SendKeys(PayrollData);
        }

        public void MethodsP(string PaymentData)
        {
            driver.FindElement(methodsP).SendKeys(PaymentData);
        }

        public void EmployeeType(string TypeData)
        {
            driver.FindElement(employeeType).SendKeys(TypeData);
        }

        public void Gender(string GenderData)
        {
            driver.FindElement(gender).SendKeys(GenderData);
        }

        public void Title(string TitleData)
        {
            driver.FindElement(title).SendKeys(TitleData);
        }

        public void PaymentFrequency(string FrequencyData)
        {
            driver.FindElement(paymentFrequency).SendKeys(FrequencyData);
        }

        public void FirstName(string FirstData)
        {
            driver.FindElement(firstName).SendKeys(FirstData);
        }

        public void LastName(string LastData)
        {
            driver.FindElement(lastName).SendKeys(LastData);
        }

        public void DateOfBirth(string BirthData)
        {
            driver.FindElement(dateOfBirth).SendKeys(BirthData);
        }

        public void Age(string AgeData)
        {
            driver.FindElement(age).SendKeys(AgeData);
        }

        public void PayslipMethods(string PayslipData)
        {
            driver.FindElement(payslipMethods).SendKeys(PayslipData);
        }

        public void NextButton()
        {
            driver.FindElement(nextButton).Click();
        }






    }
}
