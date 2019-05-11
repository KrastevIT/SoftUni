using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var values = input.Split();

            var calculatorStack = new Stack<string>(values.Reverse());

            while (calculatorStack.Count > 1)
            {
                int firstOperand = int.Parse(calculatorStack.Pop());
                string operand = calculatorStack.Pop();
                int secondOperand = int.Parse(calculatorStack.Pop());

                switch (operand)
                {
                    case "+":
                        calculatorStack.Push((firstOperand + secondOperand).ToString());
                        break;
                    case "-":
                        calculatorStack.Push((firstOperand - secondOperand).ToString());
                        break;
                    default:
                        calculatorStack.Push(0.ToString());
                        break;
                }
            }

            Console.WriteLine(calculatorStack.Pop());
        }
    }
}
