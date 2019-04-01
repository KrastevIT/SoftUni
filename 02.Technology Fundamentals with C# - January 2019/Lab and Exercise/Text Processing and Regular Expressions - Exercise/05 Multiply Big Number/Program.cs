using System;
using System.Numerics;

namespace _05_Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            BigInteger totalSum = firstNumber * secondNumber;

            Console.WriteLine(totalSum);
        }
    }
}
