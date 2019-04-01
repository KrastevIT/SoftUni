using System;
using System.Text.RegularExpressions;

namespace _08_Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            MatchCollection matched = Regex.Matches(text,regex);

            Console.WriteLine(string.Join(" ",matched));
        }
    }
}
