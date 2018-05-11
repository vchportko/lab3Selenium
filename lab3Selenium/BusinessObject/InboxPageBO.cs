using lab3Selenium.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab3Selenium.BusinessObject
{
    public class InboxPageBO
    {
        private InboxPage InboxPage;

        public InboxPageBO(IWebDriver driver)
        {
            InboxPage = new InboxPage(driver);
        }

        public void MarkCheckbox(int index = 0)
        {
            try
            {
                InboxPage.WaitAndClickCollection(InboxPage.Rows, index);
            }
            catch
            {
                InboxPage.WaitAndClick(InboxPage.Rows[index]);
            }
        }

        public void MarkAsImportant()
        {
            InboxPage.WaitAndClick(InboxPage.MenuButton);
            InboxPage.WaitAndClick(InboxPage.MarkAsNotImportantButton);
            InboxPage.WaitAndClick(InboxPage.MenuButton);
            InboxPage.WaitAndClick(InboxPage.MarkAsImportantButton);
        }
    }
}
