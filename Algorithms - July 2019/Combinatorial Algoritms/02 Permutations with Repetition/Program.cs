using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Permutations_with_Repetition
{
    class Program
    {
        static char[] elements;

        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
               .Split()
               .Select(char.Parse)
               .ToArray();

            elements = new char[input.Length];
            elements = input;

            Permute(0);

        }

        private static void Permute(int index)
        {
            if (index == elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
            }
            else
            {
                Permute(index + 1);
                HashSet<char> used = new HashSet<char>();
                used.Add(elements[index]);

                for (int i = index + 1; i < elements.Length; i++)
                {
                    if (!used.Contains(elements[i]))
                    {
                        used.Add(elements[i]);

                        Swap(index, i);
                        Permute(index + 1);
                        Swap(index, i);
                    }
                }
            }
        }

        private static void Swap(int i, int j)
        {
            var temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
