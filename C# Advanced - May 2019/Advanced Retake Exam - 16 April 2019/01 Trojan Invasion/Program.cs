using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Trojan_Invasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            int[] plates = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            var queuePlates = new Queue<int>(plates);

            var stackWarrior = new Stack<int>();

            for (int i = 1; i <= numberOfWaves; i++)
            {
                int[] warrior = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

                stackWarrior = new Stack<int>(warrior);

                if (i % 3 == 0)
                {
                    int plate = int.Parse(Console.ReadLine());

                    queuePlates.Enqueue(plate);
                }

                while (queuePlates.Any() && stackWarrior.Any())
                {
                    int currentSum = stackWarrior.Peek() - queuePlates.Peek();

                    if (currentSum < 0)
                    {
                        stackWarrior.Pop();

                        queuePlates.Dequeue();

                        queuePlates = new Queue<int>(queuePlates.Reverse());

                        queuePlates.Enqueue(Math.Abs(currentSum));

                        queuePlates = new Queue<int>(queuePlates.Reverse());
                    }
                    else if (currentSum > 0)
                    {
                        stackWarrior.Pop();

                        stackWarrior.Push(currentSum);

                        queuePlates.Dequeue();
                    }
                    else if (currentSum == 0)
                    {
                        queuePlates.Dequeue();

                        stackWarrior.Pop();
                    }
                }

                if (queuePlates.Count == 0)
                {
                    break;
                }
            }


            if (queuePlates.Any())
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", queuePlates)}");
            }
            else if (stackWarrior.Any())
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", stackWarrior)}");
            }
        }
    }
}
