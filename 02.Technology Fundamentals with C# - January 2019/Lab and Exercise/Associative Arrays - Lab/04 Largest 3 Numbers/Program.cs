using System;
using System.Linq;

namespace _04_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var top3 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .OrderByDescending(x => x)
                 .Take(3);

            Console.WriteLine(string.Join(" ", top3));
        }
    }
}
