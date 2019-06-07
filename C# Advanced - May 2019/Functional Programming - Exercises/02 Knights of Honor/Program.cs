using System;

namespace _02_Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names =>
           Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            string[] inputNames = Console.ReadLine().Split();

            printNames(inputNames);
        }
    }
}
