using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var petrolPumps = new Queue<int[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                petrolPumps.Enqueue(input);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var currentPetrolPump in petrolPumps)
                {
                    int fuel = currentPetrolPump[0];
                    int distance = currentPetrolPump[1];

                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        index++;
                        int[] pumpForRemove = petrolPumps.Dequeue();
                        petrolPumps.Enqueue(pumpForRemove);
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
