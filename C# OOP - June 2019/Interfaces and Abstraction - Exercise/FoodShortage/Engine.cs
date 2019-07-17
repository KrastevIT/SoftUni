using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShortage
{
    public class Engine
    {
        private List<IBuyer> identify;

        public Engine()
        {
            identify = new List<IBuyer>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                if (inputArgs.Length == 4)
                {
                    Citizen citizen = new Citizen(
                        inputArgs[0],
                        int.Parse(inputArgs[1]),
                        inputArgs[2],
                        inputArgs[3]);

                    identify.Add(citizen);
                }
                else if (inputArgs.Length == 3)
                {
                    Rebel rebel = new Rebel(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]);

                    identify.Add(rebel);
                }
            }

            string name = Console.ReadLine();

            while (name != "End")
            {
                var currentBuyer = identify.FirstOrDefault(x => x.Name == name);

                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(identify.Select(x => x.Food).Sum());
        }
    }
}
