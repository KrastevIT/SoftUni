using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Mammal;

namespace WildFarm.Animals.Mammal
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
