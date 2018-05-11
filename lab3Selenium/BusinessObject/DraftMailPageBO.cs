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
    public class DraftMailPageBO
    {
        private DraftMailPage DraftMailPage { get; set; }

        public DraftMailPageBO(IWebDriver driver)
        {
            DraftMailPage = new DraftMailPage(driver);
        }

        public void OpenMail(int index = 0)
        {
            DraftMailPage.WaitAndClickCollection(DraftMailPage.Mails, index);
        }
    }
}
