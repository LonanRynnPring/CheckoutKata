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

            [TestMethod]
            public void IncreaseStock_AddTwoItems_CorrectStock()
            {
                // Arrange
                int expected = 2;
                Item item = new Item(0, 10, "none");

                // Act
                item.IncreaseStock();
                item.IncreaseStock();

                // Assert
                int actual = item.Amount;
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Cost_AddOneItem_CorrectPrice()
            {
                // Arrange
                double expected = 10;
                Item item = new Item(0, 10, "none");

                // Act
                item.IncreaseStock();

                // Assert
                double actual = item.Cost();
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Cost_AddTwoItemsWithPercentageDiscount_CorrectPrice()
            {
                // Arrange
                double expected = 15;
                Item item = new Item(0, 10, "25% off for every 2 purchased together");

                // Act
                item.IncreaseStock();
                item.IncreaseStock();

                // Assert
                double actual = item.Cost();
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Cost_AddThreeItemsWithThreeForFortyDiscount_CorrectPrice()
            {
                // Arrange
                double expected = 40;
                Item item = new Item(0, 10, "3 for 40");

                // Act
                item.IncreaseStock();
                item.IncreaseStock();
                item.IncreaseStock();

                // Assert
                double actual = item.Cost();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
