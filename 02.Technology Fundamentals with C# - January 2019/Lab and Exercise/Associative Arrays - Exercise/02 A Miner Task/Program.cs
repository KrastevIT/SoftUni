using System;
using System.Collections.Generic;

namespace _02_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            var resourceAndQuatity = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourceAndQuatity.ContainsKey(resource))
                {
                    resourceAndQuatity[resource] = quantity;
                }
                else
                {
                    resourceAndQuatity[resource] += quantity;
                }


                resource = Console.ReadLine();
            }

            foreach (var kvp in resourceAndQuatity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
