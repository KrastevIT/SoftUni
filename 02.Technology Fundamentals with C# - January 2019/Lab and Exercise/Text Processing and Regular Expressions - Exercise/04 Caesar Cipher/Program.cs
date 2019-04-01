using System;
using System.Text;

namespace _04_Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder srb = new StringBuilder();

            foreach (var word in input)
            {
                char encrypted = (char)(word + 3);
                srb.Append(encrypted);
            }

            Console.WriteLine(srb);
        }
    }
}
