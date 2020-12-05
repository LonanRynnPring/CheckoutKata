using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataNS
{
    class Item
    {
        private int _amount;
        private double _unitPrice;

        public Item(int amount, double unitPrice)
        {
            _amount = amount;
            _unitPrice = unitPrice;
        }

        public int Amount
        {
            get { return _amount; }
        }

        public double UnitPrice
        {
            get { return _unitPrice; }
        }
    }
}
