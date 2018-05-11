using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Selenium.PageObject
{
    public class SentMailPage : EnterPage
    {
        [FindsBy(How = How.CssSelector, Using = "[gh='tl'] div div table tbody tr :nth-child(5)")]
        public IList<IWebElement> Mails { get; private set; }

        public SentMailPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
