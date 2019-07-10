using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person()
        {
            bag = new List<Product>();
        }
        public Person(string name, decimal money)
            : this()
        {
            Name = name;
            Money = money;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NullOrEmptyNameException);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeMoneyException);
                }

                this.money = value;
            }
        }


        public void BuyProduct(Product product)
        {
            decimal moneyLeft = Money - product.Cost;

            if (moneyLeft < 0)
            {
                throw new InvalidOperationException(string.Format(
                    ExceptionMessages.CannotAffordProductException, Name, product.Name));
            }

            Money = moneyLeft;
            bag.Add(product);
        }

        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }

            return $"{Name} - {string.Join(", ", bag)}";
        }
    }
}
