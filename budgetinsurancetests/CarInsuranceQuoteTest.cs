using System;
using NUnit.Framework;
using budgetinsurance;
using budgetinsurance.SitePages;

namespace budgetinsurancetests
{
    [TestFixture]
    class CarInsuranceQuoteTest
    {
        [Test]
        public void Can_Go_To_CarInsuranceQuote()
        {
            //Pages.HomePage.Goto();
            Pages.CarInsuranceQuote.Goto();
            Assert.IsTrue(Pages.CarInsuranceQuote.IsAt());
        }
    }
}
