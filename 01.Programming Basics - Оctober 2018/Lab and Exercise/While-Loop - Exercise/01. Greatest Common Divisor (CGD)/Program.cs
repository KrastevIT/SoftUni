using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (true)
            {
                if (a > b)
                {
                    a = a % b;

                }
                else if (b > a)
                {
                    b = b % a;
                }

                if (a == 0)
                {
                    Console.WriteLine(b);
                    break;
                }
                else if (b == 0)
                {
                    Console.WriteLine(a);
                    break;
                }

            }
        }

    }
}