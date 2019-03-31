using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (num >= 0 && num <= 500)
                {
                    Console.WriteLine($"{num * 0.05:F2}");
                }
                else if (num >= 500 && num <= 1000)
                {
                    Console.WriteLine($"{num * 0.07:F2}");
                }
                else if (num >= 1000 && num <= 10000)
                {
                    Console.WriteLine($"{num * 0.08:F2}");
                }
                else if (num > 10000)
                {
                    Console.WriteLine($"{num * 0.12:F2}");
                }

            }

            else if (town == "Varna")
            {

                if (num >= 0 && num <= 500)
                {
                    Console.WriteLine($"{num * 0.045:F2}");
                }
                else if (num >= 500 && num <= 1000)
                {
                    Console.WriteLine($"{num * 0.075:F2}");
                }
                else if (num >= 1000 && num <= 10000)
                {
                    Console.WriteLine($"{num * 0.10:F2}");
                }
                else if (num > 10000)
                {
                    Console.WriteLine($"{num * 0.13:F2}");
                }
            }


            else if (town == "Plovdiv")
            {

                if (num >= 0 && num <= 500)
                {
                    Console.WriteLine($"{num * 0.055:F2}");
                }
                else if (num >= 500 && num <= 1000)
                {
                    Console.WriteLine($"{num * 0.08:F2}");
                }
                else if (num >= 1000 && num <= 10000)
                {
                    Console.WriteLine($"{num * 0.12:F2}");
                }
                else if (num > 10000)
                {
                    Console.WriteLine($"{num * 0.145:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }

    }
}

