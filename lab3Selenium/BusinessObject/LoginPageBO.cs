using lab3Selenium.PageObject;
using OpenQA.Selenium;

namespace lab3Selenium.BusinessObject
{
    public class LoginPageBO
    {
        private LoginPage LoginPage;

        public LoginPageBO(IWebDriver driver)
        {
            LoginPage = new LoginPage(driver);
        }

        public void  Navigate(string url)
        {
            LoginPage.Driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string email)
        {
            LoginPage.WaitAndInput(LoginPage.LoginField, email);
        }

        public void ClickNextButton()
        {
            LoginPage.NextButton.Click();
        }
    }
}
