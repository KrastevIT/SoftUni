using System;

namespace _02_Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arrNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrNumbers[i] + " ");
            }
        }
    }
}
