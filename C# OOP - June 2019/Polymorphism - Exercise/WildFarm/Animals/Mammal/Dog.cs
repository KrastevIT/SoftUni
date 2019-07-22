using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Food;
using WildFarm.Mammal;

namespace WildFarm.Animals.Mammal
{
    public class Dog : Mammal
    {
        public const double WeightIncrease = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Foods food)
        {
            this.BaseEat(food, new List<string>() { nameof(Meat) }, WeightIncrease);
        }

        public override string SoundEat()
        {
            return "Woof!";
        }
    }
}
