using System;

namespace _07_Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputRepeat = int.Parse(Console.ReadLine());
            PrintString(input, inputRepeat);
        }

        static void PrintString(string symbol, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
