using System;

namespace _03_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] valuesAssString = values.Split();
            double[] numbers = new double[valuesAssString.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(valuesAssString[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
