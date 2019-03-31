using System;

namespace _04_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Words = Console.ReadLine();
            char[] array = Words.ToCharArray();

            Array.Reverse(array);
            Console.WriteLine(array);
            Console.ReadLine();
        }
    }
}
