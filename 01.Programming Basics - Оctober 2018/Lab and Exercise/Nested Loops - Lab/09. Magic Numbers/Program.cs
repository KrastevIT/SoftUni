using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int m = 1; m <= 9; m++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            for (int o = 1; o <= 9; o++)
                            {
                                for (int s = 1; s <= 9; s++)
                                {
                                    if (i * m * k * l * o * s == magicNumber)
                                    {
                                        Console.Write($"{i}{m}{k}{l}{o}{s} ");
                                    }

                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
