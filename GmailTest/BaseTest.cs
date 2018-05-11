using Autofac;
using lab3Selenium.BusinessObject;
using lab3Selenium.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace lab3Selenium
{
    public class BaseTest
    {
        protected static IWebDriver Driver { get; set; } = AutofacConfiguration.GetContainer().Resolve<IWebDriver>();

        #region PageObjects
        protected static LoginPageBO LoginPage { get; set; }

        protected static PasswordPageBO PasswordPage { get; set; }

        protected static EnterPageBO EnterPage { get; set; }

        protected static ComposeMailPageBO ComposeMailPage { get; set; }

        protected static SentMailPageBO SentMailPage { get; set; }

        protected static OpenedMailPageBO OpenedMailPage { get; set; }

        protected static DraftMailPageBO DraftMailPage { get; set; }

        protected static InboxPageBO InboxPage { get; set; }

        protected static ImportantPageBO ImportantPage { get; set; }

        protected static BinPageBO BinPage { get; set; }

        #endregion

        [ClassInitialize]
        public static void SetUp()
        {
            LoginPage = new LoginPageBO(Driver);
            PasswordPage = new PasswordPageBO(Driver);
            EnterPage = new EnterPageBO(Driver);
            ComposeMailPage = new ComposeMailPageBO(Driver);
            SentMailPage = new SentMailPageBO(Driver);
            OpenedMailPage = new OpenedMailPageBO(Driver);
            DraftMailPage = new DraftMailPageBO(Driver);
            InboxPage = new InboxPageBO(Driver);
            ImportantPage = new ImportantPageBO(Driver);
            BinPage = new BinPageBO(Driver);
        }

        [ClassCleanup]
        public void TearDown()
        {
            Driver.Dispose();
        }


    }
}
