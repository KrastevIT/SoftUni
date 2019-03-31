using System;

namespace _03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddPrint(firstNum, secondNum);
                    break;
                case "multiply":
                    MultiplyPrint(firstNum, secondNum);
                    break;
                case "subtract":
                    SubtractPrint(firstNum, secondNum);
                    break;
                case "divide":
                    DividePrint(firstNum, secondNum);
                    break;
            }
        }

        private static void AddPrint(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }

        private static void MultiplyPrint(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        private static void SubtractPrint(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        private static void DividePrint(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
