using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace budgetinsurance.SitePages
{
    public class AuthorPage
    {
        [FindsBy(How = How.CssSelector, Using = "div.overview h1")]
        private IWebElement authorName;
        public string AuthorName
        {
            get { return authorName.Text; }
        }
    }
}
