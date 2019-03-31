using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int length = 1;

            while (length != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (firstPlayer[0] > secondPlayer[0])
                    {
                        firstPlayer.Add(firstPlayer[0]);
                        firstPlayer.Add(secondPlayer[0]);
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                    }
                    else if (secondPlayer[0] > firstPlayer[0])
                    {
                        secondPlayer.Add(secondPlayer[0]);
                        secondPlayer.Add(firstPlayer[0]);
                        secondPlayer.RemoveAt(0);
                        firstPlayer.RemoveAt(0);
                    }
                    else
                    {
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                    }
                }

                length = Math.Min(firstPlayer.Count, secondPlayer.Count);
            }

            if (firstPlayer.Count > secondPlayer.Count)
            {
                int sum = firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }


        }
    }
}
