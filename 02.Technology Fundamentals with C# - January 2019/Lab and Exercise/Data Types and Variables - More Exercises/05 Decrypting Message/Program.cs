using System;
using System.Collections.Generic;

namespace _05_Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            List<char> word = new List<char>();

            for (int i = 0; i < n; i++)
            {
                char inputSymbol = char.Parse(Console.ReadLine());
                int SymbolNumber = Convert.ToInt32(inputSymbol);
                int sumKeyAndSymbol = SymbolNumber + key;
                char point = Convert.ToChar(sumKeyAndSymbol);
                word.Add(point);
            }
            Console.WriteLine(String.Join("",word));

        }
    }
}
