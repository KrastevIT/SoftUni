using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = Console.ReadLine().Split('|').ToArray();

            int energy = 100;
            int coins = 100;


            for (int i = 0; i < events.Length; i++)
            {
                string[] command = events[i].Split('-');
                int number = int.Parse(command[1]);

                if (command[0] == "rest")
                {
                    int currentEnergy = energy;
                    energy += number;

                    if (energy > 100)
                    {
                        Console.WriteLine($"You gained {100 - currentEnergy} energy.");
                        Console.WriteLine($"Current energy: 100.");
                        energy = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (command[0] == "order")
                {

                    if (energy >= 0)
                    {
                        energy -= 30;

                    }
                    if (energy >= 0)
                    {
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        Console.WriteLine($"You had to rest!");
                        energy += 80;
                    }
                }
                else
                {
                    coins -= number;

                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command[0]}.");
                        return;
                    }
                }
            }

            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
