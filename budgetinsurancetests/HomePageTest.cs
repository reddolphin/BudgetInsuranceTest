using System;
using NUnit.Framework;
using budgetinsurance;
using budgetinsurance.SitePages;

namespace budgetinsurancetests
{
     [TestFixture]
    public class HomePageTest
    {
         [Test]
         public void Can_Go_To_HomePage()
         {
             Pages.HomePage.Goto();
             Assert.IsTrue(Pages.HomePage.IsAt());
         }

         [Test]
         public void Can_Click_Car_Insurance_Get_Quote()
         {
             Pages.HomePage.Goto();
             Pages.HomePage.CarInsuranceGetAQuoteClick();
             Assert.IsTrue(Pages.CarInsuranceQuote.IsAt());
         }

         [TearDown]
         public void CleanUp()
         {
             //Browser.Close();
         }
    }
}
