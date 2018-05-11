using lab3Selenium.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace lab3Selenium.PageObject
{
    public class ImportantPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[gh='tl'] div div table tbody tr")]
        public IList<IWebElement> Rows { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[gh='mtb'] :first-child :nth-child(2) :nth-child(3)")]
        public IWebElement DeleteButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='G-tF'] :first-child :first-child :first-child :first-child :first-child")]
        public IWebElement MarkAllButton { get; private set; }

        public ImportantPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
