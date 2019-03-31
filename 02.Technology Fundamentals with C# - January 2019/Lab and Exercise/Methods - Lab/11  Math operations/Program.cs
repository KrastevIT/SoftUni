using System;

namespace _11__Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "/":
                    DividePrint(firstNumber, secondNumber);
                    break;
                case "*":
                    MultiplicationPrint(firstNumber, secondNumber);
                    break;
                case "+":
                    CollectionPrint(firstNumber, secondNumber);
                    break;
                case "-":
                    SubtractionPrint(firstNumber, secondNumber);
                    break;
            }
        }

        static void DividePrint(double firstSum, double secondSum)
        {
            Console.WriteLine(firstSum / secondSum);
        }

        static void MultiplicationPrint(double firstSum, double secondSum)
        {
            Console.WriteLine(firstSum * secondSum);
        }

        static void CollectionPrint(double firstSum, double secondSum)
        {
            Console.WriteLine(firstSum + secondSum);
        }

        static void SubtractionPrint(double firstSum, double secondSum)
        {
            Console.WriteLine(firstSum - secondSum);
        }
    }
}
