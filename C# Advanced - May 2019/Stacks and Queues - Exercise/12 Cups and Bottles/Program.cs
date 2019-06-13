using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] capacityCups = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] filledBottles = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            var queueCups = new Queue<int>(capacityCups);
            var stackBottles = new Stack<int>(filledBottles);

            var currentCups = new Stack<int>();

            int wastedWater = 0;

            while (true)
            {
                if (stackBottles.Peek() >= queueCups.Peek())
                {
                    wastedWater += stackBottles.Pop() - queueCups.Dequeue();
                }
                else
                {
                    int value = queueCups.Dequeue() - stackBottles.Pop();

                    currentCups = new Stack<int>(queueCups.Reverse());

                    currentCups.Push(value);

                    queueCups.Clear();

                    queueCups = new Queue<int>(currentCups);
                }


                if (queueCups.Count == 0)
                {
                    Console.WriteLine($"Bottles: " + string.Join(" ", stackBottles.Pop()));

                    Console.WriteLine($"Wasted litters of water: {wastedWater}");

                    return;
                }
                else if (stackBottles.Count == 0)
                {
                    Console.WriteLine($"Cups: " + string.Join(" ", queueCups));

                    Console.WriteLine($"Wasted litters of water: {wastedWater}");

                    return;
                }
            }
        }
    }
}
