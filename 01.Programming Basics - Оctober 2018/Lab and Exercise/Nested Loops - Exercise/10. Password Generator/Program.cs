using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (char k = 'a'; k < 'a' + o; k++)
                    {
                        for (char l = 'a'; l < 'a' + o; l++)
                        {
                            for (int m = 1; m <= n; m++)
                            {
                                if ((m > i) && (m > j))
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)l}{m} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
