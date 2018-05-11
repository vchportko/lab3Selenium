using lab3Selenium.PageObject;
using OpenQA.Selenium;

namespace lab3Selenium.BusinessObject
{
    public class PasswordPageBO
    {
        private PasswordPage PasswordPage;

        public PasswordPageBO(IWebDriver driver)
        {
            PasswordPage = new PasswordPage(driver);
        }

        public void EnterPassword(string passwordToEnter)
        {
            PasswordPage.WaitAndInput(PasswordPage.PasswordField, passwordToEnter);
        }

        public void ClickNextButton()
        {
            PasswordPage.WaitAndClick(PasswordPage.NextButton);
        }
    }
}
