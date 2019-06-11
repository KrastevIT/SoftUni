using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            var queue = new Queue<string>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}