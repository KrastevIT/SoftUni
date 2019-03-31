using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int m = a; m <= b; m++)
                {
                    for (int k = c; k <= d; k++)
                    {
                        for (int l = c; l <= d; l++)
                        {
                            if (i + k == m + l && i != m && k != l)
                            {
                                Console.WriteLine($"{i}{m}");
                                Console.WriteLine($"{l}{k}");
                                Console.WriteLine();
                            }


                        }
                    }
                }
            }
        }
    }
}
