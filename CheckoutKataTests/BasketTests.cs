using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CheckoutKataNS;

namespace CheckoutKataTests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void AddItem_AddOneItemA_CorrectPrice()
        {
            // Arrange
            double expected = 10;
            Basket checkout = new Basket();
            Item A = new Item(0, 10, "none");
            Item B = new Item(0, 15, "3 for 40");
            Item C = new Item(0, 40, "none");
            Item D = new Item(0, 55, "25% off for every 2 purchased together");
            Item[] basket = { A, B, C, D };

            // Act
            checkout.AddItem(A, basket);

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItem_AddThreeItemB_CorrectPrice()
        {
            // Arrange
            double expected = 40;
            Basket checkout = new Basket();
            Item A = new Item(0, 10, "none");
            Item B = new Item(0, 15, "3 for 40");
            Item C = new Item(0, 40, "none");
            Item D = new Item(0, 55, "25% off for every 2 purchased together");
            Item[] basket = { A, B, C, D };

            // Act
            for (int i = 0; i < 3; i++)
            {
                checkout.AddItem(B, basket);
            }

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItem_AddFourItemB_CorrectPrice()
        {
            // Arrange
            double expected = 55;
            Basket checkout = new Basket();
            Item A = new Item(0, 10, "none");
            Item B = new Item(0, 15, "3 for 40");
            Item C = new Item(0, 40, "none");
            Item D = new Item(0, 55, "25% off for every 2 purchased together");
            Item[] basket = { A, B, C, D };

            // Act
            checkout.AddItem(B, basket);
            checkout.AddItem(B, basket);
            checkout.AddItem(B, basket);
            checkout.AddItem(B, basket);

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItem_AddTwoItemD_CorrectPrice()
        {
            // Arrange
            double expected = 82.5;
            Basket checkout = new Basket();
            Item A = new Item(0, 10, "none");
            Item B = new Item(0, 15, "3 for 40");
            Item C = new Item(0, 40, "none");
            Item D = new Item(0, 55, "25% off for every 2 purchased together");
            Item[] basket = { A, B, C, D };

            // Act
            checkout.AddItem(D, basket);
            checkout.AddItem(D, basket);

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItem_AddThreeItemD_CorrectPrice()
        {
            // Arrange
            double expected = 137.5;
            Basket checkout = new Basket();
            Item A = new Item(0, 10, "none");
            Item B = new Item(0, 15, "3 for 40");
            Item C = new Item(0, 40, "none");
            Item D = new Item(0, 55, "25% off for every 2 purchased together");
            Item[] basket = { A, B, C, D };

            // Act
            checkout.AddItem(D, basket);
            checkout.AddItem(D, basket);
            checkout.AddItem(D, basket);

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItem_AddAllItems_CorrectPrice()
        {
            // Arrange
            double expected = 120;
            Basket checkout = new Basket();
            Item A = new Item(0, 10, "none");
            Item B = new Item(0, 15, "3 for 40");
            Item C = new Item(0, 40, "none");
            Item D = new Item(0, 55, "25% off for every 2 purchased together");
            Item[] basket = { A, B, C, D };

            // Act
            checkout.AddItem(A, basket);
            checkout.AddItem(B, basket);
            checkout.AddItem(C, basket);
            checkout.AddItem(D, basket);

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddItem_AddAllItemsWithDiscounts_CorrectPrice()
        {
            // Arrange
            double expected = 172.5;
            Basket checkout = new Basket();
            Item A = new Item(0, 10, "none");
            Item B = new Item(0, 15, "3 for 40");
            Item C = new Item(0, 40, "none");
            Item D = new Item(0, 55, "25% off for every 2 purchased together");
            Item[] basket = { A, B, C, D };

            // Act
            checkout.AddItem(A, basket);
            checkout.AddItem(B, basket);
            checkout.AddItem(B, basket);
            checkout.AddItem(B, basket);
            checkout.AddItem(C, basket);
            checkout.AddItem(D, basket);
            checkout.AddItem(D, basket);

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }
    }
}
