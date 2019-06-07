using System;
using System.Linq;

namespace _08_Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> softFunc = (x, y)
                => (x % 2 == 0 && y % 2 != 0) ? -1
                : (x % 2 != 0 && y % 2 == 0) ? 1 :
                x > y ? 1 : x < y ? -1 : 0;

            Array.Sort(numbers, (x, y) => softFunc(x, y));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
