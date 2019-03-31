using System;

namespace _09_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string symbolFirst = Console.ReadLine();
            string symbolSecond = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(symbolFirst);
                    int secondInt = int.Parse(symbolSecond);
                    InputOfInteger(firstInt, secondInt);
                break;
                case "char":
                    char firstChar = char.Parse(symbolFirst);
                    char secondChar = char.Parse(symbolSecond);
                    InputOfChar(firstChar, secondChar);
                    break;
                case "string":
                    InputOfString(symbolFirst, symbolSecond);
                    break;
            }
        }

        static void InputOfInteger(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
        }

        static void InputOfChar(char firstSymbol, char secondSymbol)
        {
            if (firstSymbol > secondSymbol)
            {
                Console.WriteLine(firstSymbol);
            }
            else if (secondSymbol > firstSymbol)
            {
                Console.WriteLine(secondSymbol);
            }
        }

        static void InputOfString(string firstStr, string secondStr)
        {
            Console.WriteLine(secondStr);
        }


    }
}
