using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace LawTrust_UI_TestAutomation.pages
{
    public class RegistrationPage
    {
       
         By _userName = By.XPath("//input[@id='userName']");
         By _email = By.XPath("//input[@id='email1']");
         By _mobileNumber = By.XPath("//input[@id='mobile']");
         By _jobTitle = By.XPath("//input[@id='job']");
         By _company = By.XPath("//input[@id='company']");
         By _terms = By.XPath("//*[@id='check']");
         By _submitButton = By.XPath("//button[@type='submit']");



        private IWebDriver _driver;

        public RegistrationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement INameTxtBox => _driver.FindElement(_userName);

        public IWebElement IEmailTxtBox => _driver.FindElement(_email);

        public IWebElement IMobilePhoneTxtBox => _driver.FindElement(_mobileNumber);
    
        public IWebElement ITitleTxtBox => _driver.FindElement(_jobTitle);

        public IWebElement ICompanyNameTxtBox => _driver.FindElement(_company);

        public IWebElement ITerms => _driver.FindElement(_terms);

        public IWebElement ISubmitButton => _driver.FindElement(_submitButton);

       
    }
}

        










