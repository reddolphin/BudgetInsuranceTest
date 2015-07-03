using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using budgetinsurance.SitePages;

namespace budgetinsurance
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        public static CarInsuranceQuote CarInsuranceQuote
        {
            get
            {
                var carInsuranceQuote = new CarInsuranceQuote();
                PageFactory.InitElements(Browser.Driver, carInsuranceQuote);
                return carInsuranceQuote;
            }
        }
    }
}
