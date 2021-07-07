using AutomationZeel.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationZeel.PageObject
{
    class PayrollLoginPage
    {
        public IWebDriver driver;

        public PayrollLoginPage()
        {
            driver = WebHook.driver;
        }

        private By username = By.Id("body_tbUsername");
        private By password = By.Id("body_tbPassword");
        private By login = By.Id("body_btnLogin");

        public void UserName()
        {
            driver.FindElement(username).Clear();
            driver.FindElement(username).SendKeys("Automation Tester");
        }
        public void Password()
        {
            driver.FindElement(password).Clear();

           
            driver.FindElement(password).SendKeys("Arsenal1");
            //Thread.Sleep(5000);
        }

        public void ClickLOginButton()
        {
           // Thread.Sleep(5000);
            driver.FindElement(login).Click();
        }












    }
}
