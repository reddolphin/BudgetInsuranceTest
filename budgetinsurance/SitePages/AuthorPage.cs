using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace budgetinsurance.SitePages
{
    public class AuthorPage
    {
        [FindsBy(How = How.CssSelector, Using = "body > div.ng-scope > div:nth-child(2) > section.hero > div > div.small-12.large-10.medium-9.columns.pull-over > h1")]
        private IWebElement authorName;
        public string AuthorName
        {
            get { return authorName.Text; }
        }
    }
}
