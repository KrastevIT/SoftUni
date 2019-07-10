using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BaseToppingCalories = 2;

        private Dictionary<string, double> validType;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            validType = new Dictionary<string, double>();

            SeedTypes();

            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (!validType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double CalculatedCalories()
        {
            double calories = BaseToppingCalories * validType[Type.ToLower()] * Weight;

            return calories;
        }

        public void SeedTypes()
        {
            validType.Add("meat", 1.2);
            validType.Add("veggies", 0.8);
            validType.Add("cheese", 1.1);
            validType.Add("sauce", 0.9);
        }
    }
}
