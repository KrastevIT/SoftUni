using System;
using System.Collections.Generic;

namespace _01_Reverse_Strings
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var stringReverser = new Stack<char>();

            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                stringReverser.Push(ch);
            }

            while (stringReverser.Count > 0)
            {
                Console.Write(stringReverser.Pop());
            }

        }
    }
}
