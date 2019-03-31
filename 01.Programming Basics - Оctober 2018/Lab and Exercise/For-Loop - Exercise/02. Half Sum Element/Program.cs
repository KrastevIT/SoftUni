using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            int sumSmaller = sum - maxNum;

            if (sumSmaller == maxNum)
            {
                Console.WriteLine($"Yes sum = {maxNum}");
            }
            else
            {
                Console.WriteLine($"No diff = {Math.Abs(maxNum - sumSmaller)}");
            }
        }
    }
}
