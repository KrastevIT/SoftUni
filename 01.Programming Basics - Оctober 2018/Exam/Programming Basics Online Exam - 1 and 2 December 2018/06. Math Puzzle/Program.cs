using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool end = false;

            for (int i = 1; i <= 30; i++)
            {
                for (int k = 1; k <= 30; k++)
                {
                    for (int l = 1; l <= 30; l++)
                    {

                        if (i + k + l == n)
                        {
                            if (i < k && k < l)
                            {
                                Console.WriteLine($"{i} + {k} + {l} = {i + k + l}");
                                end = true;
                            }
                         
                        }

                        if (i * k * l == n)
                        {
                            if (i > k && k > l)
                            {
                                Console.WriteLine($"{i} * {k} * {l} = {i * k * l}");
                                end = true;
                            }

                        }

                    }
                }
            }

            if (end == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
