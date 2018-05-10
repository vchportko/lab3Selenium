using Autofac;
using lab3Selenium.BusinessObject;
using lab3Selenium.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TestConfiguration = lab3Selenium.Configuration.TestConfiguration;

namespace lab3Selenium
{
    [TestClass]

    public class GmailTest
    {
        private IWebDriver Driver { get; set; } = AutofacConfiguration.GetContainer().Resolve<IWebDriver>();

        private LoginPageBO LoginPage { get; set; }

        private PasswordPageBO PasswordPage { get; set; }

        private InboxPageBO InboxPage { get; set; }

        private ComposeMailPageBO ComposeMailPage { get; set; }

        private SentMailPageBO SentMailPage { get; set; }

        private OpenedMailPageBO OpenedMailPage { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            LoginPage = new LoginPageBO(Driver);
            PasswordPage = new PasswordPageBO(Driver);
            InboxPage = new InboxPageBO(Driver);
            ComposeMailPage = new ComposeMailPageBO(Driver);
            SentMailPage = new SentMailPageBO(Driver);
            OpenedMailPage = new OpenedMailPageBO(Driver);

            LoginPage.Navigate(TestConfiguration.Url);
            LoginPage.EnterEmail(TestConfiguration.Email);
            LoginPage.ClickNextButton();
            PasswordPage.EnterPassword(TestConfiguration.Password);
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
            InboxPage.ClickCompose();
            ComposeMailPage.InputToField(TestConfiguration.Email);
            ComposeMailPage.InputSubjectField(TestConfiguration.MailSubject);
            ComposeMailPage.InputMessageField(TestConfiguration.Message);
            ComposeMailPage.ClickSendButton();
            InboxPage.GoToSendFolder();
            SentMailPage.OpenMail();

            Assert.AreEqual(OpenedMailPage.GetSubjectText(), TestConfiguration.MailSubject);
            Assert.AreEqual(OpenedMailPage.GetMessageText(), TestConfiguration.Message);

            OpenedMailPage.DeleteMail();
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

        private void InitializePages()
        {

        }
    }
}
