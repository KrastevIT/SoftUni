using System;

namespace _01_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int smallNumber = 0;
            PrintSmallNumber(firstNumber, secondNumber, thirdNumber, smallNumber);

        }

        static void PrintSmallNumber(int firstNum, int secondNum, int thirdNum, int smallNum)
        {
            if (firstNum < secondNum)
            {
                smallNum = firstNum;
            }
            else if (secondNum < firstNum)
            {
                smallNum = secondNum;
            }
            else if (firstNum == secondNum)
            {
                smallNum = firstNum;
            }
            if (thirdNum < smallNum)
            {
                smallNum = thirdNum;
            }
            Console.WriteLine(smallNum);
        }
    }
}
