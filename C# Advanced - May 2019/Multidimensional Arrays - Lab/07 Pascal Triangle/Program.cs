using System;

namespace _07_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jaggedNumbers = new long[n][];

            int cols = 1;

            for (int i = 0; i < n; i++)
            {
                jaggedNumbers[i] = new long[cols];
                jaggedNumbers[i][0] = 1;
                jaggedNumbers[i][cols - 1] = 1;

                if (cols > 2)
                {
                    long[] previousRow = jaggedNumbers[i - 1];

                    for (int j = 1; j < cols - 1; j++)
                    {
                        jaggedNumbers[i][j] = previousRow[j] + previousRow[j - 1];
                    }
                }

                cols++;
            }

            foreach (long[] row in jaggedNumbers)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
