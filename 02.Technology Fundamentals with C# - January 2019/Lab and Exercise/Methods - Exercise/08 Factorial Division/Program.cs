using System;
using System.Numerics;

namespace _08_Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputFavtorial = int.Parse(Console.ReadLine());
            int inputDivided = int.Parse(Console.ReadLine());

            PrintSumFactorial(inputFavtorial, inputDivided);
        }

        private static void PrintSumFactorial(int inputFavtorial, int inputDivided)
        {
            double FirstSum = inputFavtorial;

            for (int i = inputFavtorial; i >= 3; i--)
            {
                FirstSum *= i - 1;
            }

            double secondSum = inputDivided;

            for (int k = inputDivided; k >= 3; k--)
            {
                secondSum *= k - 1;
            }

            Console.WriteLine($"{FirstSum / secondSum:F2}");



        }
    }
}
