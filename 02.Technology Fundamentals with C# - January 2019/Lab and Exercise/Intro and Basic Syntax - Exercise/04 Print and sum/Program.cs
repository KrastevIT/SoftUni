using System;

namespace _04_Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInput = int.Parse(Console.ReadLine());
            int finalInput = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int number = startInput; number <= finalInput; number++)
            {
                Console.Write(number + " ");
                counter += number;
                
            }
            Console.WriteLine();
            Console.Write($"Sum: {counter}");
            Console.WriteLine();
        }
    }
}
