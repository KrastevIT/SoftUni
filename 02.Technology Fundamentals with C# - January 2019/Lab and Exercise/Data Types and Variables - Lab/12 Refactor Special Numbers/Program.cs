using System;

namespace _12_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            int total = 0;
            int specialNumber = 0;
            bool test = false;

            for (int i = 1; i <= inputNumbers; i++)
            {
                specialNumber = i;

                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }

                test = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", specialNumber, test);
                total = 0;
                i = specialNumber;
            }
        }
    }
}
