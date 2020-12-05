using System;
using System.Collections.Generic;
using System.Text;
using CheckoutKataNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKataTests
{
    class ItemTests
    {
        [TestClass]
        public class BasketTests
        {
            [TestMethod]
            public void IncreaseStock_AddOneItem_CorrectStock()
            {
                // Arrange
                int expected = 1;
                Item item = new Item(0, 10, "none");

                // Act
                item.IncreaseStock();

                // Assert
                int actual = item.Amount;
                Assert.AreEqual(expected, actual);
            }
        }

    }
}
