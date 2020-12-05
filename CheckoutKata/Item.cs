using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataNS
{
    public class Item
    {
        private int _amount;
        private double _unitPrice;
        private string _discount;

        public Item(int amount, double unitPrice, string discount)
        {
            _amount = amount;
            _unitPrice = unitPrice;
            _discount = discount;
        }

        public int Amount
        {
            get { return _amount; }
        }

        public double UnitPrice
        {
            get { return _unitPrice; }
        }

        public string Discount
        {
            get { return _discount; }
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
