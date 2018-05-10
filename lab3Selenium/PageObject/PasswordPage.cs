using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace lab3SeleniumInfrastracture.PageObject
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using ="identifierId")]
        public IWebElement LoginField { get; }

        [FindsBy(How = How.Id, Using = "identifierNext")]
        public IWebElement NextButton { get; }
    }
}
