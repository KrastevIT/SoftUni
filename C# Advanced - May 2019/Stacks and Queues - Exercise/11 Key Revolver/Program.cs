using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());

            int sizeOfGun = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int valueOfIntelligence = int.Parse(Console.ReadLine());

            var stackBullets = new Stack<int>(bullets);

            var queueLocks = new Queue<int>(locks);

            int counter = 0;

            int bulletCost = 0;

            while (stackBullets.Count > 0 && queueLocks.Count > 0)
            {

                if (stackBullets.Peek() <= queueLocks.Peek())
                {
                    Console.WriteLine("Bang!");

                    queueLocks.Dequeue();

                    stackBullets.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");

                    stackBullets.Pop();
                }

                counter++;

                if (counter == sizeOfGun)
                {
                    if (stackBullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");

                        counter = 0;
                    }
                }

                bulletCost++;
            }

            if (stackBullets.Count == 0 && queueLocks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
            else
            {
                int cost = bulletCost * priceBullet;
                int moneyEarned = valueOfIntelligence - cost;

                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${moneyEarned}");
            }

        }
    }
}
