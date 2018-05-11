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
    public class EnterPageBO
    {
        private EnterPage EnterPage;

        public EnterPageBO(IWebDriver driver)
        {
            EnterPage = new EnterPage(driver);
        }

        public void ClickCompose()
        {
            EnterPage.WaitAndClick(EnterPage.ComposeButton);
        }

        public void GoToSendFolder()
        {
            EnterPage.WaitAndClick(EnterPage.SentMailButton);
            EnterPage.WaitUntilClickable(EnterPage.SentMailButtonSelected);
        }   
        
        public void GoToDraftFolder()
        {
            EnterPage.WaitAndClick(EnterPage.DraftButton);
            EnterPage.WaitUntilClickable(EnterPage.DraftButtonSelected);
        }

        public void GoToInboxFolder()
        {
            EnterPage.WaitAndClick(EnterPage.InboxButton);
            EnterPage.WaitUntilClickable(EnterPage.InboxButtonSelected);
        }

        public void GoToImportantFolder()
        {
            EnterPage.WaitAndClick(EnterPage.ImportantButton);
            EnterPage.WaitUntilClickable(EnterPage.ImportantButtonSelected);
        }

        public void GoToTrashFolder()
        {
            EnterPage.WaitAndClick(EnterPage.TrashButton);
        }

        public void ClickMoreButton()
        {
            EnterPage.WaitAndClick(EnterPage.MoreButton);
        }

    }
}
