using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace budgetinsurance.SitePages
{
    public class CarInsuranceQuote
    {
        //static string Url = "https://www.budgetinsurance.com/PrivateCar/Vehicle/Welcome.aspx";
        static string Url = "https://www.budgetinsurance.com/PrivateCar/Vehicle/Welcome.aspx?ton_t=BUDPC&TDUID=&prdcls=PC&rqstyp=welcome&aid=";
        
        [FindsBy(How = How.CssSelector, Using = "#ctl00_CPH1_NewQuoteView_PostcodeView_TextBoxPostcode")]
        private IWebElement postCodeTextBox;

        public void PostCodeEnterText(string postcode)
        {
            postCodeTextBox.SendKeys(postcode);
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }
        
        public bool IsAt()
        
        {
            IWebElement findTitle = Browser.Driver.FindElement(By.CssSelector("#HeaderContent .HeaderText .HeaderTextLarge"));
            return findTitle.Text=="Welcome to your Car insurance quote";
        }


    }
}
