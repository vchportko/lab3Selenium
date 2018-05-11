using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace lab3Selenium.PageObject
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement LoginField { get; private set; }

        [FindsBy(How = How.Id, Using = "identifierNext")]
        public IWebElement NextButton { get; private set; }

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
