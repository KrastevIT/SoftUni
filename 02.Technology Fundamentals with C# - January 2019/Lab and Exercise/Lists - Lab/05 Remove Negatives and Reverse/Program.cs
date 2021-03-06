﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0)
                .ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
