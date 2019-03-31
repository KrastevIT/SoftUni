using System;

namespace _03_Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());

            PrintChar(firstInput,secondInput);
        }

        static void PrintChar(char start, char end)
        {
            
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;

            }
            for (char i = (char)(start + 1); i < end ; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
