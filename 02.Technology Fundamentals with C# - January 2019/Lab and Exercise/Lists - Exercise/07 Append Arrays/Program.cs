using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNumber = Console.ReadLine()
             .Split('|')
             .ToList();

            inputNumber.Reverse();
            List<string> result = new List<string>();

            foreach (var item in inputNumber)
            {
                List<string> splitNumbers = item.Split(' ').ToList();

                foreach (var num in splitNumbers)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
