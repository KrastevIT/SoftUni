using System;
using System.Text.RegularExpressions;

namespace _08_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();

            string regex = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            var matched = Regex.Matches(inputNumbers, regex);

            Console.WriteLine(string.Join(", ",matched));
        }
    }
}
