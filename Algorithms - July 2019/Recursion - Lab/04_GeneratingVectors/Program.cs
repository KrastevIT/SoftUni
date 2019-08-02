using System;

namespace _04_GeneratingVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] vectors = new int[number];

            Generate(vectors, 0);
        }

        public static void Generate(int[] vectors, int index)
        { 
            if (index >= vectors.Length)
            {
                Console.WriteLine(string.Join("", vectors));

            }
            else
            {
                for (int i = 0; i <= 2; i++)
                {
                    vectors[index] = i;
                    Generate(vectors, index + 1);
                }
            }
        }
    }
}
