using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Coding
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string strN = n.ToString();



            for (int i = 0; i < strN.Length; i++)
            {
                int number = n % 10;
                int lastDigit = n / 10;
                n = lastDigit;

                if (number == 0)
                {
                    Console.Write("ZERO");
                }
                for (int z = 0; z < number; z++)
                {
                    int ascii = number + 33;
                    char symbol = (char)ascii;
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
