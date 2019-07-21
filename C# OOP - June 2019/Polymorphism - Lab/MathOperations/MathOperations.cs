using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Add(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }

        public decimal Add(decimal firstNum, decimal secondNum, decimal thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }
    }
}
