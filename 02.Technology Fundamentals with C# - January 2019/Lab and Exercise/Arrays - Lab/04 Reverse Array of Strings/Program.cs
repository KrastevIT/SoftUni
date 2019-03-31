using System;

namespace _04_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();

            for (int i = arrInput.Length - 1; i >= 0; i--)
            {
                Console.Write(arrInput[i] + " ");
            }
        }
    }
}
