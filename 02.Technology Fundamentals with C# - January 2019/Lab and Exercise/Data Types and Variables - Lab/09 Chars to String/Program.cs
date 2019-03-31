using System;

namespace _09_Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = new string[3];

            for (int i = 0; i < 3; i++)
            {
                symbols[i] = Console.ReadLine();
            }

            Console.WriteLine(String.Join("", symbols));
        }
    }
}
