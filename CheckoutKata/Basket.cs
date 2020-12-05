using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataNS
{
    public class Basket
    {
        public double basketTotal;

        public void AddItem(Item SKU, Item[] basket)
        {
            SKU.IncreaseStock();
            // calculate total
        }

        public void CalculateBasketTotal(Item[] basket)
        {
            double total = 0;
            basketTotal = 0;
            foreach (Item item in basket)
            {
                total += item.Cost();
            }
            basketTotal += total;
        }
    }
}
