using System;
using System.Linq;

namespace _07_Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firsName = Console.ReadLine();
            string secoundName = Console.ReadLine();
            string[] symbol = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (var item in symbol)
            {
                Console.WriteLine($"{firsName}{item}{secoundName}");
            }
        }
    }
}
