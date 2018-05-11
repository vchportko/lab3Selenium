using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace lab3Selenium.PageObject
{
    public class BinPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[gh='tl'] div div table tbody tr")]
        public IList<IWebElement> Mails { get; private set; }

        public BinPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
