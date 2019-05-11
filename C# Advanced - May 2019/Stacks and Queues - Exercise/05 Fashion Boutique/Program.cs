using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            var stackOfRacks = new Stack<int>(clothes);

            int count = 0;

            while (true)
            {
                int currentSum = capacity;

                while (stackOfRacks.Count != 0)
                {
                    if (currentSum - stackOfRacks.Peek() >= 0)
                    {
                        currentSum -= stackOfRacks.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                count++;

                if (stackOfRacks.Count == 0)
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}

