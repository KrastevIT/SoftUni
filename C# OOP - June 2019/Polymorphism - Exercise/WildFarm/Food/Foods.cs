using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Food
{
    public abstract class Foods
    {
        protected Foods(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
