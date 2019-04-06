using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Dungeonest_Dark
{
    class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {
            string[] dungeonsRooms = Console.ReadLine()
                .Split('|')
                .ToArray();

            int health = 100;
            int coins = 0;

            for (int i = 0; i < dungeonsRooms.Length; i++)
            {
                string[] getNumberAndgetChar = dungeonsRooms[i].Split().ToArray();
                int number = int.Parse(getNumberAndgetChar[1]);

                if (getNumberAndgetChar[0] == "potion")
                {
                    int currentHealth = health;
                    health += number;
                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - currentHealth} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                    }
                }
                else if (getNumberAndgetChar[0] == "chest")
                {
                    coins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {getNumberAndgetChar[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {getNumberAndgetChar[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
