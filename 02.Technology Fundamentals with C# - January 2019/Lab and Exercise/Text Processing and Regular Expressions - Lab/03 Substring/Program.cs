using System;

namespace _03_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(stringToRemove))
            {
                text = text.Replace(stringToRemove, "");
            }

            Console.WriteLine(text);
        }
    }
}
