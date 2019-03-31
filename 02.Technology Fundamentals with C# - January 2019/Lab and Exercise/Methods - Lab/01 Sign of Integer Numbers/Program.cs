using System;

namespace _01_Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSignInteger(int.Parse(Console.ReadLine()));
        }

        static void PrintSignInteger(int number)
        {

            if (number > 0)
            {
                Console.WriteLine($"he number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
