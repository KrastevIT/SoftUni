using System;

namespace _01_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3]; // със това създаваш 3 цифрен array

            for (int i = 0; i < intArray.Length; i++) // тук казваш цъкала да върти колкото е голям arraya
            {
                
                intArray[i] = int.Parse(Console.ReadLine()); // приемаш новата цифра от конзолата на всеки цъкъл (трите числа) и издлиза

            }
            Array.Sort(intArray); // сортира ги по големина ({4}{1}{3}={1}{3}{4})
            Array.Reverse(intArray); // обръща вече сортирания array иначе е от най малкото към най голямото {1}{3}{4}={4}{3}{1}

            for (int x = 0; x < intArray.Length; x++)
            {
                Console.WriteLine(intArray[x]); // и тук вече си ги разпечатваш сортирани = 4 3 1
            }
        }
    }
}
