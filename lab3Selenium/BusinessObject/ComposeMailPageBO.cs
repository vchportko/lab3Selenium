using lab3Selenium.PageObject;
using OpenQA.Selenium;

namespace lab3Selenium.BusinessObject
{
    public class ComposeMailPageBO
    {
        private ComposeMailPage ComposeMailPage;

        public ComposeMailPageBO(IWebDriver driver)
        {
            ComposeMailPage = new ComposeMailPage(driver);
        }

        public void InputToField(string text)
        {
            ComposeMailPage.WaitAndInput(ComposeMailPage.ToField, text);
        }

        public void InputMessageField(string text)
        {
            ComposeMailPage.WaitAndInput(ComposeMailPage.MessageField, text);
        }

        public void InputSubjectField(string text)
        {
            ComposeMailPage.WaitAndInput(ComposeMailPage.SubjectField, text);
        }

        public void ClickSendButton()
        {
            ComposeMailPage.WaitAndClick(ComposeMailPage.SendButton);
        }

        public void ClickCloseButton()
        {
            ComposeMailPage.WaitAndClick(ComposeMailPage.CloseButton);
        }

        public string GetSubjectText()
        {
            return ComposeMailPage.WaitAndRead(ComposeMailPage.SubjectField);
        }

        public string GetMessageText()
        {
            return ComposeMailPage.WaitAndRead(ComposeMailPage.MessageField);
        }

        public void CloseError()
        {
            ComposeMailPage.WaitAndClick(ComposeMailPage.OkCloseErrorButton);
        }

        public string GetErrorMessageHeader()
        {
            return ComposeMailPage.WaitAndRead(ComposeMailPage.ErrorMessageHeader);
        }

        public void EnableToField()
        {
            ComposeMailPage.WaitAndClick(ComposeMailPage.ToFieldEnable);
        }

        public void ClickDeleteWrongEmailButton()
        {
            ComposeMailPage.WaitAndClick(ComposeMailPage.DeleteWrongEmailButton);
        }

    }
}
