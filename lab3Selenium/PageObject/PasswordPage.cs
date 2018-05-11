using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace lab3Selenium.PageObject
{
    public class PasswordPage: BasePage
    {
        [FindsBy(How = How.Name, Using ="password")]
        public IWebElement PasswordField { get; private set; }

        [FindsBy(How = How.Id, Using = "passwordNext")]
        public IWebElement NextButton { get; private set; }

        public PasswordPage(IWebDriver driver): base(driver)
        {

        }
    }
}
