using System;

namespace _06_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + input; i++)
            {
                for (char k = 'a'; k < 'a' + input; k++)
                {
                    for (char l = 'a'; l < 'a' + input; l++)
                    {
                        Console.WriteLine($"{i}{k}{l}");
                    }
                }
            }
        }
    }
}
