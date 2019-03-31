using System;

namespace _10_Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol >= 65 && symbol <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if(symbol >= 97 && symbol <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
