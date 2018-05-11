using lab3Selenium.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Selenium.BusinessObject
{
    public class SentMailPageBO
    {
        private SentMailPage SentMailPage { get; set; }

        public SentMailPageBO(IWebDriver driver)
        {
            SentMailPage = new SentMailPage(driver);
        }

        public void OpenMail(int index = 0)
        {
            SentMailPage.WaitAndClickCollection(SentMailPage.Mails, index);
        }
    }
}
