using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Food;
using WildFarm.Mammal;

namespace WildFarm.Animals.Mammal
{
    public class Mouse : Mammal
    {
        public const double WeightIncrease = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Foods food)
        {
            this.BaseEat(food, new List<string>() { nameof(Vegetable), nameof(Fruit) }, WeightIncrease);
        }

        public override string SoundEat()
        {
            return "Squeak";
        }
    }
}
