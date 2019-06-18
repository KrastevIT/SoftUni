using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> vegetablesCalories = new Dictionary<string, int>()
            {
                {"tomato",80 },
                {"carrot",136 },
                {"lettuce",109 },
                {"potato",215 }
            };

            string[] inputVegetables =
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int[] inputSalads =
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<string> vegetables = new Queue<string>(inputVegetables);

            Stack<int> salads = new Stack<int>(inputSalads);

            List<int> saladsReady = new List<int>();

            int caloriesRest = 0;

            while (vegetables.Any() && salads.Any())
            {
                int saladCalories = salads.Peek();

                while (saladCalories > 0 && vegetables.Any())
                {
                    if (vegetablesCalories.ContainsKey(vegetables.Peek()))
                    {
                        saladCalories -= vegetablesCalories[vegetables.Dequeue()];
                    }
                    else
                    {
                        vegetables.Dequeue();
                    }
                }

                saladCalories -= caloriesRest;

                caloriesRest = Math.Abs(saladCalories);

                saladsReady.Add(salads.Pop());
            }

            Console.WriteLine(string.Join(' ', saladsReady));

            if (vegetables.Any())
            {
                Console.WriteLine(string.Join(' ', vegetables));
            }
            if (salads.Any())
            {
                Console.WriteLine(string.Join(' ', salads));
            }
        }
    }
}