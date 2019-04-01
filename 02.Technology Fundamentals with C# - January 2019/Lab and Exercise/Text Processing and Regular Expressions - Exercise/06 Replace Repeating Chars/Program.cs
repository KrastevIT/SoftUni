using System;
using System.Text;

namespace _06_Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    output.Append(input[i]);
                }
                else if (input[i - 1] != input[i])
                {
                    output.Append(input[i]);
                }
            }

            Console.WriteLine(output);
        }
    }
}
