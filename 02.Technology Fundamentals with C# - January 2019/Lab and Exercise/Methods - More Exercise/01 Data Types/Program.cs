using System;
using System.Linq;

namespace _01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string input = Console.ReadLine();

            PrintTypeInt(dataType, input);
            PrintTypeDouble(dataType, input);
            PrintTypeString(dataType, input);
        }

        private static void PrintTypeString(string dataType, string input)
        {
            if (dataType == "string")
            {
                Console.WriteLine($"${input}$");
            }
        }

        private static void PrintTypeDouble(string dataType, string input)
        {
            if (dataType == "real")
            {
                double inputDouble = double.Parse(input);
                Console.WriteLine($"{inputDouble * 1.5:F2}");
            }
        }

        private static void PrintTypeInt(string dataType, string input)
        {
            if (dataType == "int")
            {
                int inputInt = int.Parse(input);
                Console.WriteLine(inputInt * 2);
            }
        }
    }
}
