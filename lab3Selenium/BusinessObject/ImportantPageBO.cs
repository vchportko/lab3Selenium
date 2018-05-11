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
    public class ImportantPageBO
    {
        private ImportantPage ImportantPage;

        public ImportantPageBO(IWebDriver driver)
        {
            ImportantPage = new ImportantPage(driver);
        }

        public void MarkCheckbox(int index = 0)
        {
            if (ImportantPage.Rows.Count > index)
            {
                ImportantPage.WaitAndClickCollection(ImportantPage.Rows, index);
            }
        }

        public bool CheckCount(int count = 0)
        {
            return ImportantPage.Rows.Count() > count;
        }

        public void ClickDeleteButton()
        {
            ImportantPage.WaitAndClick(ImportantPage.DeleteButton);
        }
    }
}
