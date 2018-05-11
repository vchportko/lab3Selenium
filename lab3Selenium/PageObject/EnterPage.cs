using lab3Selenium.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace lab3Selenium.PageObject
{
    public class EnterPage : BasePage
    {
        [FindsBy(How=How.CssSelector, Using = "[gh='cm']")]
        public IWebElement ComposeButton { get;  private set; }

        [FindsBy(How = How.CssSelector, Using = "[title*='Inbox']")]
        public IWebElement InboxButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[title*='Sent Mail']")]
        public IWebElement SentMailButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[title*='Drafts']")]
        public IWebElement DraftButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[title*='Important']")]
        public IWebElement ImportantButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[title*='Bin']")]
        public IWebElement TrashButton { get; private set; }

        [FindsBy(How = How.ClassName, Using = "CJ")]
        public IWebElement MoreButton { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='aim ain'] div div div span a[title*='Inbox']")]
        public IWebElement InboxButtonSelected { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='aim ain'] div div div span a[title*='Sent Mail']")]
        public IWebElement SentMailButtonSelected { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='aim ain'] div div div span a[title*='Drafts']")]
        public IWebElement DraftButtonSelected { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[class='aim ain'] div div div span a[title*='Important']")]
        public IWebElement ImportantButtonSelected { get; private set; }

        public EnterPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
