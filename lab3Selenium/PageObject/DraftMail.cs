using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace lab3Selenium.PageObject
{
    public class DraftMailPage : EnterPage
    {
        [FindsBy(How =How.CssSelector, Using = "[gh='tl'] div div table tbody tr")]
        public IList<IWebElement> Mails { get; private set; }

        public DraftMailPage(IWebDriver driver):base(driver)
        {

        }
    }
}
