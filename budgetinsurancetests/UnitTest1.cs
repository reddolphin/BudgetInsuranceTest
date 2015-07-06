using System;
using NUnit.Framework;
using budgetinsurance;
using budgetinsurance.SitePages;

namespace budgetinsurancetests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }

    }
}
