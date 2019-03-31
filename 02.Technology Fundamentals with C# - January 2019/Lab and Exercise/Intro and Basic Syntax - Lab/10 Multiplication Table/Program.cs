using System;

namespace _10_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;

            for (int num = 1; num <= 10; num++)
            {
                result = input * num;
                Console.WriteLine($"{input} X {num} = {result}");
            }
            
        }
    }
}
