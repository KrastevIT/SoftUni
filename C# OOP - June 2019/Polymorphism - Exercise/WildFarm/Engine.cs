using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Food;
using WildFarm.Mammal;

namespace WildFarm
{
    public class Engine
    {
        private List<Animal> animals = new List<Animal>();
        public void Run()
        {
            string commad = Console.ReadLine();

            while (commad != "End")
            {
                string[] animalArgs = commad.Split();

                Animal animal = AnimalFactory.Create(animalArgs);

                string[] foodArgs = Console.ReadLine().Split();

                Foods food = FoodFactory.Create(foodArgs);

                Console.WriteLine(animal.SoundEat());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);

                commad = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
