using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int male = int.Parse(Console.ReadLine());
            int female = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            for (int i = 1; i <= male; i++)
            {
                for (int k = 1; k <= female; k++)
                {
                    if (tables == 0)
                    {
                        break;
                    }
                    Console.Write($"({i} <-> {k}) ");
                    tables--;
                }
            }
        }
    }
}
