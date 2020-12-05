using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataNS
{
    public class Item
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

        public void IncreaseStock()
        {
            _amount++;
        }

        public double Cost()
        {
            return StandardPricing();
        }

        private double StandardPricing()
        {
            return _amount * _unitPrice;
        }

        private double ThreeForFortyDiscount()
        {
            return _amount * _unitPrice;
        }

        private double TwentyFivePercentDiscount()
        {
            return _amount * _unitPrice;
        }
    }
}
