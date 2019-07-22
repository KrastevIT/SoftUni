using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Mammal;

namespace WildFarm.Animals.Mammal.Feline
{
    public abstract class Felines : Mammal
    {
        protected Felines(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
