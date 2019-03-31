using System;
namespace _04_Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 0; i < input; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                totalSum += symbol;
            }
            Console.WriteLine($"The sum equals: {totalSum}");

        }
    }
}
