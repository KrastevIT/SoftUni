using System;
using System.Linq;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[n];
            int sum = 0;


            for (int i = 0; i < n; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
                sum += arrNumbers[i];
            }
            for (int k = 0; k < arrNumbers.Length; k++)
            {
                Console.Write(arrNumbers[k] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
