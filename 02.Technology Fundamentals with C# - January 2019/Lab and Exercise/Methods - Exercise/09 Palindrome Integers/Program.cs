using System;
using System.Linq;

namespace _09_Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            PrintPalindromeYesOrNo(command);
           
        }

        private static void PrintPalindromeYesOrNo(string command)
        {
            while (command != "END")
            {
                string reverseCommand = new string(command.Reverse().ToArray());

                if (command == reverseCommand)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
        }
    }
}
