using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Family_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            double sumElectric = 0;
            double sumWater = 0;
            double sumInternet = 0;

            for (int i = 1; i <= month; i++)
            {
                double electric = double.Parse(Console.ReadLine());
                sumElectric += electric;
            }

            sumWater = month * 20;
            sumInternet = month * 15;

            double allSum = (sumElectric + sumWater + sumInternet);
            double percentSum = allSum * 0.20;
            double other = allSum + percentSum;

            double averageMonth = (sumElectric + sumWater + sumInternet + other) / month;


            Console.WriteLine($"Electricity: {sumElectric:F2} lv");
            Console.WriteLine($"Water: {sumWater:F2} lv");
            Console.WriteLine($"Internet: {sumInternet:F2} lv");
            Console.WriteLine($"Other: {other:F2} lv");
            Console.WriteLine($"Average: {averageMonth:F2} lv");


        }
    }
}
