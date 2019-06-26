using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputLiquids = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] inpuItems = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            var liquids = new Queue<int>(inputLiquids);
            var items = new Stack<int>(inpuItems);

            int aluminium = 0;
            int carbonFiber = 0;
            int glass = 0;
            int lithim = 0;


            while (liquids.Any() && items.Any())
            {
                int sum = liquids.Peek() + items.Peek();

                if (sum == 25)
                {
                    glass++;

                    liquids.Dequeue();
                    items.Pop();
                }
                else if (sum == 50)
                {
                    aluminium++;

                    liquids.Dequeue();
                    items.Pop();
                }
                else if (sum == 75)
                {
                    lithim++;

                    liquids.Dequeue();
                    items.Pop();
                }
                else if (sum == 100)
                {
                    carbonFiber++;

                    liquids.Dequeue();
                    items.Pop();
                }
                else
                {
                    liquids.Dequeue();

                    int number = items.Pop();

                    items.Push(number + 3);
                }
            }

            if (aluminium > 0 &&
                carbonFiber > 0 &&
                glass > 0 &&
                lithim > 0)
            {
                Console.WriteLine($"Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Any())
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }


            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {carbonFiber}");
            Console.WriteLine($"Glass: {glass}");
            Console.WriteLine($"Lithium: {lithim}");
        }
    }
}
