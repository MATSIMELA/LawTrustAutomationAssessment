using System;
using TechTalk.SpecFlow;
using LawTrust_UI_TestAutomation.pages;
using LawTrust_UI_TestAutomation.Test;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow.Assist;

namespace LawTrust_UI_TestAutomation.Features
{
    [Binding]
    public class iGivenStepDefinations : BaseTest
    {
        private RegistrationPage registrationPage;
        private LoginPage loginPage;


    

        [Given(@"""(.*)"" Page is displayed")]
        public void GivenPageIsDisplay(string p0)
        {

            if (p0.Equals("Login"))
            {
                SetUp();
                loginPage = new LoginPage(Driver);
            }

            if (p0.Equals("Registration"))
            {
                registrationPage = new RegistrationPage(Driver);
            }
           
        }
        
        [Given(@"I click ""(.*)"" button")]
        public void GivenIClickButton(string p0)
        {
            if (p0.Equals("Sign Up"))
            {
              
                loginPage.ISignButtonButton.Click();
            }

            if (p0.Equals("Next"))
            {
              
             loginPage.NextButton.Click();

            }
        }


        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            registrationPage.INameTxtBox.SendKeys((string) data.Name);

            registrationPage.IEmailTxtBox.SendKeys((string)data.Email);

            int number = data.MobileNumber;
            string mobileNum = number.ToString();
            registrationPage.IMobilePhoneTxtBox.SendKeys(mobileNum);

            registrationPage.ITitleTxtBox.SendKeys((string)data.JobTitle);

            registrationPage.ICompanyNameTxtBox.SendKeys((string)data.CompanyName);

            if (((string)data.TermsAndConditions).Equals("Accept")){

                new Actions(Driver).MoveToElement(registrationPage.ITerms, 1, 1).Click().Perform();


            }

        }

        [When(@"I click ""(.*)"" button")]
        public void GivenIClickBtn(string p0)
        {
           

            if (p0.Equals("Next"))
            {

                loginPage.NextButton.Click();

            }
        }


        [Then(@"I expect to see title ""(.*)""")]
        public void ThenIExpectToSeeTitle(string p0)
        {
            registrationPage.ISubmitButton.Click();
        }

    }
}
