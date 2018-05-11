using lab3Selenium.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Selenium.PageObject
{
    public class BasePage
    {
        public IWebDriver Driver { get; }

        protected WebDriverWait Wait { get; }


        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            driver.Manage().Window.Maximize();

            Wait = new WebDriverWait(Driver,
                TimeSpan.FromSeconds(Convert.ToInt32(TestConfiguration.WaitTimeout)));

            PageFactory.InitElements(driver, this);

        }

        public void WaitUntilClickable(IWebElement webElement)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
        }

        public void WaitAndClick(IWebElement webElement)
        {
            WaitUntilClickable(webElement);
            webElement.Click();            
        }

        public void WaitAndClickCollection(IList<IWebElement> webElements, int index = 0)
        {
            WaitUntilClickable(webElements[index]);
            webElements[index].Click();
        }

        public void WaitAndInput(IWebElement webElement, string text)
        {
            WaitUntilClickable(webElement);

            webElement.SendKeys(text);
        }

        public string WaitAndRead(IWebElement webElement)
        {
            WaitUntilClickable(webElement);

            return webElement.Text;
        }
    }
}
