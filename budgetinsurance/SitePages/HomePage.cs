using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace budgetinsurance.SitePages
{
    public class HomePage
    {
        static string Url = "http://www.budgetinsurance.com/";
        private static string PageTitle = "Budget has provided great value, quality insurance for over 1 million cars in the UK since 1992. Budget has a UK based service team and 24/7 claims line.";

        [FindsBy(How = How.CssSelector, Using = "#productCar getquote .focusable")]
        private IWebElement carInsuranceGetQuoteLink;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void CarInsuranceGetAQuoteClick()
        {
            carInsuranceGetQuoteLink.Click();
        }
    }
}
