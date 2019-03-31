using System;

namespace _7.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string firsWord = Console.ReadLine().ToLower();
            string secontWord = Console.ReadLine().ToLower();

            if (firsWord==secontWord)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
