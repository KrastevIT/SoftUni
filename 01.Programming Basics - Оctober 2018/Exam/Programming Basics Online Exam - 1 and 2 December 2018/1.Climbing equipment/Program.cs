using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Climbing_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int alpinisti = int.Parse(Console.ReadLine());
            double sumKarabineri = double.Parse(Console.ReadLine());
            double sumVujeta = double.Parse(Console.ReadLine());
            double sumPikelite = double.Parse(Console.ReadLine());

            double karibineri = sumKarabineri * 36;
            double vajeta = sumVujeta * 3.60;
            double pikeli = sumPikelite * 19.80;

            double allSumAlpinist = karibineri + vajeta + pikeli;
            double allSum = allSumAlpinist * alpinisti;
            double sumDDS = allSum * 0.20;
            double totalSum = allSum + sumDDS;
            Console.WriteLine($"{totalSum:F2}");



        }
    }
}
