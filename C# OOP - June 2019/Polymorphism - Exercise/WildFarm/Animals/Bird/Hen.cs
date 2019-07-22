using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Food;

namespace WildFarm.Animals.Bird
{
    public class Hen : Bird
    {
        public const double WeightIncrease = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Foods food)
        {
            this.BaseEat(food,
                new List<string>()
                {
                    nameof(Vegetable),
                    nameof(Fruit),
                    nameof(Meat),
                    nameof(Seeds)
                },
                WeightIncrease);
        }

        public override string SoundEat()
        {
            return "Cluck";
        }
    }
}
