using lab3Selenium.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3SeleniumInfrastracture.PageObject
{
    public class OpenedMailPage: EnterPage
    {
        [FindsBy(How=How.CssSelector, Using = "h2.hP")]
        public IWebElement SubjectText { get; private set; }

        [FindsBy(How = How.CssSelector, Using = ".gs div div div[dir = 'ltr']")]
        public IWebElement MessageText { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[gh='mtb'] :first-child :nth-child(2) :nth-child(3)")]
        public IWebElement DeleteButton { get; private set; }

        public OpenedMailPage(IWebDriver driver):base(driver)
        {

        }


    }
}
