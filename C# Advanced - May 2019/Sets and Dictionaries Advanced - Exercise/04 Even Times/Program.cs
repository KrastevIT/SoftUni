using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new Dictionary<int, int>();


            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 0);
                }

                numbers[input]++;
            }

            int evenTimesNumber = numbers
                .SingleOrDefault(x => x.Value % 2 == 0)
                .Key;

            Console.WriteLine(evenTimesNumber);

        }
    }
}
