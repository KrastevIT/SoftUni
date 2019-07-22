using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Food;
using WildFarm.Mammal;

namespace WildFarm.Animals.Mammal.Feline
{
    public class Tiger :Felines
    {
        public const double WeightIncrease = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Foods food)
        {
            this.BaseEat(food, new List<string>() { nameof(Meat) }, WeightIncrease);
        }

        public override string SoundEat()
        {
            return "ROAR!!!";
        }
    }
}
