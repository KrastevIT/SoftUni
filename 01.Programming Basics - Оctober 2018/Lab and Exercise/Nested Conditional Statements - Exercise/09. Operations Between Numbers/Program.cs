using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;

            if (symbol == "+")
            {
                result = (n1 + n2);
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
                }
            }
            else if (symbol == "-")
            {
                result = (n1 - n2);
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
                }
            }
            else if (symbol == "*")
            {
                result = (n1 * n2);
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
                }
            }
            else if (symbol == "/")
            {
                if (n2 != 0)
                {
                    result = n1 / n2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", n1, symbol, n2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
            }
            else if (symbol == "%")
            {
                if (n2 != 0)
                {
                    result = n1 % n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, symbol, n2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
            }
        }
    }
}
