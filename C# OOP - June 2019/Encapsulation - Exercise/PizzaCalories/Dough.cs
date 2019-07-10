using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double BaseDoughCalories = 2;

        private Dictionary<string, double> validFlourType;
        private Dictionary<string, double> validBakingTechnique;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.validFlourType = new Dictionary<string, double>();
            this.validBakingTechnique = new Dictionary<string, double>();

            SeedFlourType();
            SeedBakingTechnique();

            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (!validFlourType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (!validBakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
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
                if (value < 1 || value > 200)
                {
                    throw new AggregateException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public void SeedFlourType()
        {
            this.validFlourType.Add("white", 1.5);
            this.validFlourType.Add("wholegrain", 1.0);
        }

        public void SeedBakingTechnique()
        {
            this.validBakingTechnique.Add("crispy", 0.9);
            this.validBakingTechnique.Add("chewy", 1.1);
            this.validBakingTechnique.Add("homemade", 1.0);
        }

        public double CalculatedCalories()
        {
            double calories = BaseDoughCalories * weight * validFlourType[FlourType.ToLower()] *
                validBakingTechnique[BakingTechnique.ToLower()];

            return calories;
        }
    }
}
