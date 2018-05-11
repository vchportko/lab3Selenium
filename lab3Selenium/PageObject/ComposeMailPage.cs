using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace lab3Selenium.PageObject
{
    public class ComposeMailPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[class='aoD hl']")]
        public IWebElement ToFieldEnable { get; private set; }
        
        [FindsBy(How = How.ClassName, Using = "vM")]
        public IWebElement DeleteWrongEmailButton { get; private set; }

        [FindsBy(How = How.Name, Using = "to")]
        public IWebElement ToField { get; private set; }

        [FindsBy(How = How.Name, Using = "subjectbox")]
        public IWebElement SubjectField { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "div[class='Am Al editable LW-avf']:first-of-type")]
        public IWebElement MessageField { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='J-J5-Ji btA']:first-child")]
        public IWebElement SendButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "img.Ha")]
        public IWebElement CloseButton { get; private set; }

        [FindsBy(How = How.Name, Using = "ok")]
        public IWebElement OkCloseErrorButton { get; private set; }

        [FindsBy(How = How.ClassName, Using = "Kj-JD-K7-K0")]
        public IWebElement ErrorMessageHeader { get; private set; }
        public ComposeMailPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
