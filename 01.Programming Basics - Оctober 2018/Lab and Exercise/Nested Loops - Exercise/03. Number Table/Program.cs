using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int num2 = n;
                for (int j = 1; j <= n; j++)
                {
                    if (num > n)
                    {
                        num2--;
                        Console.Write(num2 + " ");
                    }
                    else
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
