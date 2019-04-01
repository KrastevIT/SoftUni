using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToRemove = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            

            foreach (var word in wordsToRemove)
            {
                string stars = new string('*', word.Length);
                text = text.Replace(word, stars);
            }

            Console.WriteLine(text);
        }
    }
}
