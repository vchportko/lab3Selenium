using lab3Selenium.PageObject;
using OpenQA.Selenium;

namespace lab3Selenium.BusinessObject
{
    public class BinPageBO
    {
        private BinPage BinPage;

        public BinPageBO(IWebDriver driver)
        {
            BinPage = new BinPage(driver);
        }

        public bool CheckCount(int count = 0)
        {
            return BinPage.Mails.Count > count;
        }
    }
}
