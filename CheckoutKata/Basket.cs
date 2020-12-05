using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataNS
{
    class Basket
    {
        public double basketTotal;

        public void AddItem(Item SKU, int[] basket)
        {
            SKU.IncreaseStock();
            // calculate total
        }
    }
}
