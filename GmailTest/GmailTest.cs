using System;
using Autofac;
using lab3Selenium.BusinessObject;
using lab3Selenium.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace lab3Selenium
{
    [TestClass]

    public class GmailTest
    {
        private IWebDriver Driver { get; set; } = AutofacConfiguration.GetContainer().Resolve<IWebDriver>();

        private LoginPageBO LoginPage { get; set; }

        private PasswordPageBO PasswordPage { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            LoginPage = new LoginPageBO(Driver);
            PasswordPage = new PasswordPageBO(Driver);

            LoginPage.Navigate(Configuration.TestConfiguration.Url);
            LoginPage.EnterEmail(Configuration.TestConfiguration.Email);
            LoginPage.ClickNextButton();
            PasswordPage.EnterPassword(Configuration.TestConfiguration.Password);
            PasswordPage.ClickNextButton();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Quit();
            Driver.Dispose();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod4()
        {
        }
    }
}
