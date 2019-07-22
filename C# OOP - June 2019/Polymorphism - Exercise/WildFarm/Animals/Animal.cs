using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Food;

namespace WildFarm
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; private set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract string SoundEat();

        public abstract void Eat(Foods food);

        protected void BaseEat(Foods food, List<string> eatableFood, double gainValue)
        {
            string typeFood = food.GetType().Name;

            if (!eatableFood.Contains(typeFood))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {typeFood}!");
            }

            this.Weight += food.Quantity * gainValue;
            this.FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, ";
        }
    }
}
