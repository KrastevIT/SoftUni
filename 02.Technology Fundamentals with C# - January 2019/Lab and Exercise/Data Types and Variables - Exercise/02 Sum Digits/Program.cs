﻿using System;

namespace _02_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = 0;

            while (number != 0)
            {
                digit += number % 10;
                number /= 10;
            }
            Console.WriteLine(digit);


        }
    }
}
