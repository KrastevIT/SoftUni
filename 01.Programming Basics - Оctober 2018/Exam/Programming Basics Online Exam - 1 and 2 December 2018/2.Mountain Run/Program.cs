using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double rekord = double.Parse(Console.ReadLine());
            double metri = double.Parse(Console.ReadLine());
            double secundi = double.Parse(Console.ReadLine());

            double izckachi = metri * secundi;
            double dobavqne = Math.Floor(metri / 50);
            double sumSecundi = dobavqne * 30;

            double obshtoVreme = izckachi + sumSecundi;

            if (rekord <= obshtoVreme)
            {
                Console.WriteLine($"No! He was {obshtoVreme - rekord:F2} seconds slower.");
            }
            else 
            {
                Console.WriteLine($"Yes! The new record is {obshtoVreme:F2} seconds.");

            }

        }
    }
}
