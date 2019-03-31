using System;
using System.Linq;

namespace _05_Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            int[] arrNumber = inputNumbers.Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arrNumber.Length; i++)
            {
                if (arrNumber[i] % 2 == 0)
                {
                    sum += arrNumber[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
