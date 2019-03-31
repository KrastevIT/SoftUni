﻿using System;
using System.Linq;

namespace _03_Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine($"{word} ");
            }
        }
    }
}
