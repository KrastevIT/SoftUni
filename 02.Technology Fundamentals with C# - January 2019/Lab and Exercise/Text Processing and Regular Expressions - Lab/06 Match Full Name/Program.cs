using System;
using System.Text.RegularExpressions;

namespace _06_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var matches = Regex.Matches(text, @"\b([A-Z][a-z]+) ([A-Z][a-z]+\b)");

            Console.WriteLine(string.Join(" ",matches));


        }
    }
}
