using LawTrust.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace LawTrust_UI_TestAutomation.Test
{
    [NUnit.Framework.TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver;
        private readonly string _baseUrl = Constants.BaseUrl;

        [SetUp]
        public void SetUp()
        {
       
            new DriverManager().SetUpDriver(new FirefoxConfig());
            Driver = new FirefoxDriver();
            Driver.Manage().Window.Maximize();

            string _baseUrl = Constants.BaseUrl;
            Driver.Navigate().GoToUrl(_baseUrl);
            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
    

