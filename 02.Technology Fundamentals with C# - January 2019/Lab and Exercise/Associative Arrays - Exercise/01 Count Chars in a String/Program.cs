using System;
using System.Collections.Generic;

namespace _01_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var characters = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                for (int k = 0; k < word.Length; k++)
                {
                    string point = word[k].ToString();

                    if (!characters.ContainsKey(point))
                    {
                        characters[point] = 0;
                    }

                    characters[point]++;
                }
            }

            foreach (var kvp in characters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
