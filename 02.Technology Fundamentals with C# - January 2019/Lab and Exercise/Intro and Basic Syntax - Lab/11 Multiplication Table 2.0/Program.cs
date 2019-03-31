using System;

namespace _11_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            int product = 0;

            for (int num = times; num <= 10; num++)
            {
                product = input * num;
                Console.WriteLine($"{input} X {num} = {product}");
            }

            if (times > 10)
            {
                product = input * times;
                Console.WriteLine($"{input} X {times} = {product}");
            }
        }
    }
}
