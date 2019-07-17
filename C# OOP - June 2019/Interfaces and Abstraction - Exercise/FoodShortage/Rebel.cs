using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private int age;
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.age = age;
            this.group = group;
        }

        public int Food { get; private set; }

        public string Name { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
