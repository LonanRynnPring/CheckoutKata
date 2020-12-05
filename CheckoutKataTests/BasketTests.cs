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
            Item A = new Item(0, 10);
            Item B = new Item(0, 15);
            Item C = new Item(0, 40);
            Item D = new Item(0, 55);
            Item[] basket = { A, B, C, D };

            // Act
            checkout.AddItem(A, basket);

            // Assert
            double actual = checkout.basketTotal;
            Assert.AreEqual(expected, actual);
        }
    }
}
