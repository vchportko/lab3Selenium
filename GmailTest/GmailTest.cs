using Autofac;
using lab3Selenium.BusinessObject;
using lab3Selenium.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading.Tasks;
using TestConfiguration = lab3Selenium.Configuration.TestConfiguration;

namespace lab3Selenium
{
    [TestClass]
    public class GmailTest
    {
        private IWebDriver Driver { get; set; } = AutofacConfiguration.GetContainer().Resolve<IWebDriver>();

        #region PageObjects
        private LoginPageBO LoginPage { get; set; }

        private PasswordPageBO PasswordPage { get; set; }

        private EnterPageBO EnterPage { get; set; }

        private ComposeMailPageBO ComposeMailPage { get; set; }

        private SentMailPageBO SentMailPage { get; set; }

        private OpenedMailPageBO OpenedMailPage { get; set; }

        private DraftMailPageBO DraftMailPage { get; set; }

        private InboxPageBO InboxPage { get; set; }

        private ImportantPageBO ImportantPage { get; set; }

        private BinPageBO BinPage { get; set; }

        #endregion

        [TestInitialize]
        public void SetupTest()
        {
            InitializePages();

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
        public async Task TestMethod1()
        {
            EnterPage.ClickCompose();
            ComposeMailPage.InputToField(TestConfiguration.Email);
            ComposeMailPage.InputSubjectField(TestConfiguration.MailSubject);
            ComposeMailPage.InputMessageField(TestConfiguration.Message);
            ComposeMailPage.ClickSendButton();
            EnterPage.GoToSendFolder();
            SentMailPage.OpenMail();

            Assert.AreEqual(OpenedMailPage.GetSubjectText(), TestConfiguration.MailSubject, "Wrong subject");
            Assert.AreEqual(OpenedMailPage.GetMessageText(), TestConfiguration.Message, "Wrong message");

            OpenedMailPage.DeleteMail();
        }

        [TestMethod]
        [Description("Verifies if not saved message is in draft folder")]
        public void TestMethod2()
        {
            EnterPage.ClickCompose();
            ComposeMailPage.InputToField(TestConfiguration.Email);
            ComposeMailPage.InputSubjectField(TestConfiguration.MailSubject);
            ComposeMailPage.InputMessageField(TestConfiguration.Message);
            ComposeMailPage.ClickCloseButton();
            EnterPage.GoToDraftFolder();
            DraftMailPage.OpenMail();

            //Assert.AreEqual(ComposeMailPage.GetSubjectText(), TestConfiguration.MailSubject, "Wrong subject");
            Assert.AreEqual(ComposeMailPage.GetMessageText(), TestConfiguration.Message, "Wrong message");

            ComposeMailPage.ClickSendButton();
        }

        [TestMethod]
        [Description("Verifies if messages are in 'Important' folder")]
        public void TestMethod3()
        {
            EnterPage.GoToInboxFolder();
            for(int i=0;i<TestConfiguration.NumberOfMailsToCheck;i++)
            {
                InboxPage.MarkCheckbox(i);
            }
            InboxPage.MarkAsImportant();
            EnterPage.ClickMoreButton();
            EnterPage.GoToImportantFolder();

            Assert.IsTrue(ImportantPage.CheckCount(TestConfiguration.NumberOfMailsToCheck));

            for (int i = 0; i < TestConfiguration.NumberOfMailsToCheck; i++)
            {
                ImportantPage.MarkCheckbox(i);
            }
            ImportantPage.ClickDeleteButton();
            EnterPage.GoToTrashFolder();

            Assert.IsTrue(BinPage.CheckCount(TestConfiguration.NumberOfMailsToCheck));

        }

        [TestMethod]
        [Description("Verifies that message with wrong 'To' value was not sent")]
        public void TestMethod4()
        {
            EnterPage.ClickCompose();
            ComposeMailPage.InputToField(TestConfiguration.IncorrectEmail);
            ComposeMailPage.InputSubjectField(TestConfiguration.MailSubject);
            ComposeMailPage.InputMessageField(TestConfiguration.Message);
            ComposeMailPage.ClickSendButton();

            Assert.AreEqual(ComposeMailPage.GetErrorMessageHeader(), TestConfiguration.ErrorMessageHeader, "Wrong error message header");

            ComposeMailPage.CloseError();
            ComposeMailPage.EnableToField();
            ComposeMailPage.ClickDeleteWrongEmailButton();
            ComposeMailPage.InputToField(TestConfiguration.IncorrectEmail);
            EnterPage.GoToSendFolder();
            SentMailPage.OpenMail();

            //Assert.AreEqual(OpenedMailPage.GetSubjectText(), TestConfiguration.MailSubject, "Wrong subject");
            Assert.AreEqual(OpenedMailPage.GetMessageText(), TestConfiguration.Message, "Wrong message");
        }

        private void InitializePages()
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

        private void SendMessage(string to, string subject, string message)
        {
            EnterPage.ClickCompose();
            ComposeMailPage.InputToField(to);
            ComposeMailPage.InputSubjectField(subject);
            ComposeMailPage.InputMessageField(message);
            ComposeMailPage.ClickSendButton();
        }
    }
}
