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
        public void AddItem_IncreasesStock()
        {
            // Arrange
            int expected = 1;
            Basket basket = new Basket();

            // Act
            // Assert
        }
    }
}
