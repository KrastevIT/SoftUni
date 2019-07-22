using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Food;

namespace WildFarm.Animals.Bird
{
    public class Owl : Bird
    {
        public const double WeightIncrease = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Foods food)
        {
            this.BaseEat(food, new List<string>() { nameof(Meat) }, WeightIncrease);
        }

        public override string SoundEat()
        {
            return "Hoot Hoot";
        }

    }
}
