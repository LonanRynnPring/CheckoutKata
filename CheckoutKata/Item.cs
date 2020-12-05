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

        private string DISCOUNT_ONE = "3 for 40";
        private string DISCOUNT_TWO = "25% off for every 2 purchased together";

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
            if (Discount == DISCOUNT_ONE)
            {
                return ThreeForFortyDiscount();
            }
            else if (Discount == DISCOUNT_TWO)
            {
                return TwentyFivePercentDiscount();
            }
            else
            {
                return StandardPricing();
            }
        }

        private double StandardPricing()
        {
            return _amount * _unitPrice;
        }

        private double ThreeForFortyDiscount()
        {
            int numberOfTimesDiscountUsed = (_amount / 3);
            int numberBoughtAtFullPrice = _amount % 3;
            double total = numberOfTimesDiscountUsed * 40 + numberBoughtAtFullPrice * _unitPrice;
            return total;
        }

        private double TwentyFivePercentDiscount()
        {
            int numberOfItemsDiscountUsedOn = 2 * (_amount / 2);
            int numberBoughtAtFullPrice = _amount % 2;
            double total = numberOfItemsDiscountUsedOn * (_unitPrice * 0.75) + numberBoughtAtFullPrice * _unitPrice;
            return total;
        }
    }
}
