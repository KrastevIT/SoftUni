using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Product.Beverages
{
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double mililiters)
            : base(name, price, mililiters)
        {

        }
    }
}
