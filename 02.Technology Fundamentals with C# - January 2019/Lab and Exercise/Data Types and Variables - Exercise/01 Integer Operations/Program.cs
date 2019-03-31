using System;

namespace _01_Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int secound = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int firtSum = (first + secound) / third;
            int total = firtSum * fourth;

            Console.WriteLine(total);
        }
    }
}
