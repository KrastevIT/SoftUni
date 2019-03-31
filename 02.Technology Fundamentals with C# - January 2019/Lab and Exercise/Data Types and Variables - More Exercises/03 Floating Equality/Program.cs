using System;

namespace _03_Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal eps = 0.000001M;

            if (Math.Abs(firstNumber - secondNumber) >= eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }




        }
    }
}
