using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryPawnShop.Models;

namespace PawnShopTest
{
    [TestClass]
    public class PawnShopTest
    {
        [TestMethod]
        public void FillData()
        {
            PawnShop shop = new PawnShop();
            shop.FillTestData(100);
            Assert.AreEqual("Product0", shop.Deposits[0].Products[0].Name);

            
        }
    }
}
