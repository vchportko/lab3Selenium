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

        private DraftMailPageBO DraftMailPage { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            LoginPage = new LoginPageBO(Driver);
            PasswordPage = new PasswordPageBO(Driver);
            InboxPage = new InboxPageBO(Driver);
            ComposeMailPage = new ComposeMailPageBO(Driver);
            SentMailPage = new SentMailPageBO(Driver);
            OpenedMailPage = new OpenedMailPageBO(Driver);
            DraftMailPage = new DraftMailPageBO(Driver);

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
        [Description("Verifies if sent message is in 'Sent mail' folder")]
        public void TestMethod1()
        {
            InboxPage.ClickCompose();
            ComposeMailPage.InputToField(TestConfiguration.Email);
            ComposeMailPage.InputSubjectField(TestConfiguration.MailSubject);
            ComposeMailPage.InputMessageField(TestConfiguration.Message);
            ComposeMailPage.ClickSendButton();
            InboxPage.GoToSendFolder();
            SentMailPage.OpenMail();

            Assert.AreEqual(OpenedMailPage.GetSubjectText(), TestConfiguration.MailSubject, "Wrong subject");
            Assert.AreEqual(OpenedMailPage.GetMessageText(), TestConfiguration.Message, "Wrong message");

            OpenedMailPage.DeleteMail();
        }

        [TestMethod]
        [Description("Verifies if not saved message is in draft folder")]
        public void TestMethod2()
        {
            InboxPage.ClickCompose();
            ComposeMailPage.InputToField(TestConfiguration.Email);
            ComposeMailPage.InputSubjectField(TestConfiguration.MailSubject);
            ComposeMailPage.InputMessageField(TestConfiguration.Message);
            ComposeMailPage.ClickCloseButton();
            InboxPage.GoToDraftFolder();
            DraftMailPage.OpenMail();

            Assert.AreEqual(ComposeMailPage.GetSubjectText(), TestConfiguration.MailSubject, "Wrong subject");
            Assert.AreEqual(ComposeMailPage.GetMessageText(), TestConfiguration.Message, "Wrong message");

            ComposeMailPage.ClickSendButton();
        }

        [TestMethod]
        public void TestMethod3()
        {


        }

        [TestMethod]
        [Description("Verifies that message with wrong 'To' value was not sent")]
        public void TestMethod4()
        {
            InboxPage.ClickCompose();
            ComposeMailPage.InputToField(TestConfiguration.IncorrectEmail);
            ComposeMailPage.InputSubjectField(TestConfiguration.MailSubject);
            ComposeMailPage.InputMessageField(TestConfiguration.Message);
            ComposeMailPage.ClickSendButton();

            Assert.AreEqual(ComposeMailPage.GetErrorMessageHeader(), TestConfiguration.ErrorMessageHeader, "Wrong error message header");

            ComposeMailPage.CloseError();
            ComposeMailPage.EnableToField();
            ComposeMailPage.ClickDeleteWrongEmailButton();
            ComposeMailPage.InputToField(TestConfiguration.IncorrectEmail);
            InboxPage.GoToSendFolder();
            SentMailPage.OpenMail();

            Assert.AreEqual(OpenedMailPage.GetSubjectText(), TestConfiguration.MailSubject, "Wrong subject");
            Assert.AreEqual(OpenedMailPage.GetMessageText(), TestConfiguration.Message, "Wrong message");
        }

        private void InitializePages()
        {

        }
    }
}
