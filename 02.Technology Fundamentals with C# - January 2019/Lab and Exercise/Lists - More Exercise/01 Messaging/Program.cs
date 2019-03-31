using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string text = Console.ReadLine();

            int sumOfnumbers = 0;
            List<string> words = new List<string>();

            for (int j = 0; j < numbers.Length; j++)
            {
                string num = numbers[j].ToString();

                for (int i = 0; i < num.Length; i++)
                {
                    string digit = num[i].ToString();
                    sumOfnumbers += int.Parse(digit);
                }
            }

            //не е довършена!!!

    
        }
    }
}
