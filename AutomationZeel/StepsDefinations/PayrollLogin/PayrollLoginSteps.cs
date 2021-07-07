using AutomationZeel.Hooks;
using AutomationZeel.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationZeel.Steps
{
    [Binding]
    public class PayrollLoginSteps
    {
        public IWebDriver driver = WebHook.driver;

            PayrollLoginPage payrollLoginPage = new PayrollLoginPage();

        [Given(@"I am on theb website")]
        public void GivenIAmOnThebWebsite()
        {
            driver.Navigate().GoToUrl("http://zrecruiterlocal/ZPQADev2017/Pages/Login.aspx?t=s");
        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            payrollLoginPage.UserName();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            payrollLoginPage.Password();
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            payrollLoginPage.ClickLOginButton();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
           
        }
    }
}
