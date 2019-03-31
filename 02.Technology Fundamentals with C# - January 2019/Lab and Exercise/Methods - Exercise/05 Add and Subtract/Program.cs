using System;

namespace _05_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

           int firstAndSecondSum = SumFirstnumberAndSecondNumber(firstNumber, secondNumber);
           int finalSum = PrintSubtractFirstAndSecondSumFromLastNumber(firstAndSecondSum, lastNumber);
            Console.WriteLine(finalSum);
        }

        private static int PrintSubtractFirstAndSecondSumFromLastNumber(int firstAndSecondSum, int lastNumber)
        {
           return firstAndSecondSum - lastNumber;
           
        }

        private static int SumFirstnumberAndSecondNumber(int firstNumber, int secondNumber)
        {
             return  firstNumber + secondNumber;
        }
    }
}
