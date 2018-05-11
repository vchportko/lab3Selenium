using lab3Selenium.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace lab3Selenium.PageObject
{
    public class InboxPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[gh='tl'] div div table tbody tr td div[role='checkbox']")]
        public IList<IWebElement> Rows { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[gh='mtb'] :first-child :first-child :nth-child(6)")]
        public IWebElement MenuButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='J-M aX0 aYO jQjAxd'] [class='SK AX'] :nth-child(4) :first-child")]
        public IWebElement MarkAsImportantButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='J-M aX0 aYO jQjAxd'] [class='SK AX'] :nth-child(5) :first-child")]
        public IWebElement MarkAsNotImportantButton { get; private set; }

        public InboxPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
