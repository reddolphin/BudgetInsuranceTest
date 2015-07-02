using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace budgetinsurance.SitePages
{
    public class HomePage
    {
        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Pluralsight - Hardcore Developer Training";

        [FindsBy(How = How.LinkText, Using = "Authors")]
        private IWebElement authorLink;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectAuthor(string authorName)
        {
            authorLink.Click();
            var author = Browser.Driver.FindElement(By.LinkText(authorName));
            author.Click();
        }

        public bool IsAtAuthorPage(string authorName)
        {
            var authorPage = new AuthorPage();
            PageFactory.InitElements(Browser.Driver, authorPage);
            return authorPage.AuthorName == authorName;

        }
    }
}
