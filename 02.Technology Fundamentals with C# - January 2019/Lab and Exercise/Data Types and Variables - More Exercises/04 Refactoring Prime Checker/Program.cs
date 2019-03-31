using System;

namespace _04_Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 2; i <= inputNumber; i++)
            {
                bool test = true;

                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        test = false;
                        break;
                    }
                }

                if (test)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }
            }
        }
    }
}
