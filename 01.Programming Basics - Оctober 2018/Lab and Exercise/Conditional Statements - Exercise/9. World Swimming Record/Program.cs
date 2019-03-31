using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secsPerMeter = double.Parse(Console.ReadLine());

            double time = distance * secsPerMeter;
            double waterDrag = Math.Floor(distance / 15) * (12.5);
            double allTime = time + waterDrag;

            double vremetoNeStiga = allTime - record;


            if (record < allTime)
            {
                Console.WriteLine($"No, he failed! He was {vremetoNeStiga:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {allTime} seconds.");
            }
        }
    }
}
