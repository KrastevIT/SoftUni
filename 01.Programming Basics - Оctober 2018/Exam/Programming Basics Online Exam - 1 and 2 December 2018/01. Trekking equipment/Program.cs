using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trekking_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int mountaineers = int.Parse(Console.ReadLine());
            double numCarabiners = double.Parse(Console.ReadLine());
            double numRopes = double.Parse(Console.ReadLine());
            double numPickeys = double.Parse(Console.ReadLine());

            double carabiner = numCarabiners * 36.00;
            double ropes = numRopes * 3.60;
            double pickeys = numPickeys * 19.80;

            double allMountaineers = carabiner + ropes + pickeys;
            double sumMountaineers = allMountaineers * mountaineers;
            double sumDds = sumMountaineers * 0.20;
            double allSum = sumMountaineers + sumDds;
            Console.WriteLine($"{allSum:F2}");

        }
    }
}
