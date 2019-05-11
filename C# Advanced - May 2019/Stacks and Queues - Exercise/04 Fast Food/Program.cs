using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityOfFood = double.Parse(Console.ReadLine());
            int[] inputOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stackOrders = new Queue<int>(inputOrders);

            Console.WriteLine(stackOrders.Max());

            for (int i = 0; i < inputOrders.Length && quantityOfFood - stackOrders.Peek() >= 0; i++)
            {
                    quantityOfFood -= stackOrders.Dequeue();
            }

            if (stackOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", stackOrders)}");
            }
        }
    }
}
