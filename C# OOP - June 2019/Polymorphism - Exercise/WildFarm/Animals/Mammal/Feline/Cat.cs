using System;
using System.Collections.Generic;
using WildFarm.Animals.Mammal.Feline;
using WildFarm.Food;

namespace WildFarm.Mammal
{
    public class Cat : Felines

    {
        public const double WeightIncrease = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Foods food)
        {
            this.BaseEat(food, new List<string>() { nameof(Vegetable), nameof(Meat) }, WeightIncrease);
        }

        public override string SoundEat()
        {
            return "Meow";
        }

    }
}
