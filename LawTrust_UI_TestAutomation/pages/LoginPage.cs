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
    public class LoginPage
    {
         By _signUpButton = By.LinkText("Sign Up");
         By _emailTextBox = By.XPath("//input[@name='userEmail']");
         By _passwordTextBox = By.XPath("//input[@id='passwordInput']");
         By _signInButton = By.XPath("//button[@type='submit']");

         IWebDriver _driver;

         

        public LoginPage(IWebDriver driver) 
        {
            _driver = driver;
        }

        public IWebElement ISignButtonButton => _driver.FindElement(_signUpButton);

        public IWebElement IEmailAddressTextbox => _driver.FindElement(_emailTextBox);

        public IWebElement PasswordTextbox => _driver.FindElement(_passwordTextBox);

        public IWebElement NextButton => _driver.FindElement(_signInButton);

    
    }
 
    
}


