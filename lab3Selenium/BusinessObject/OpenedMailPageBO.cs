using lab3SeleniumInfrastracture.PageObject;
using OpenQA.Selenium;

namespace lab3Selenium.BusinessObject
{
    public class OpenedMailPageBO
    {
        private OpenedMailPage OpenedMailPage;

        public OpenedMailPageBO(IWebDriver driver)
        {
            OpenedMailPage = new OpenedMailPage(driver);
        }

        public string GetSubjectText()
        {
            return OpenedMailPage.WaitAndRead(OpenedMailPage.SubjectText);
        }

        public string  GetMessageText()
        {
            return OpenedMailPage.WaitAndRead(OpenedMailPage.MessageText);
        }

        public void DeleteMail()
        {
            OpenedMailPage.WaitAndClick(OpenedMailPage.DeleteButton);
        }
    }
}
