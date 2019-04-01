using System;

namespace _02_Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();

            string concatenatedString = string.Empty;

            foreach (var item in word)
            {
                int length = item.Length;

                for (int i = 0; i < length; i++)
                {
                    concatenatedString += string.Concat(item);
                }
            }

            Console.WriteLine(concatenatedString);
        }
    }
}
