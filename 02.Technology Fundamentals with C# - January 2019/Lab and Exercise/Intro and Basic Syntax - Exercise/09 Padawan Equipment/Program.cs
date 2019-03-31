using System;

namespace _09_Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double freeBelts = 0;
            double moreLight = Math.Ceiling(countStudents * 0.10);
            double totalLight = (moreLight + countStudents);
            double sabresPrice = priceLightsabers * totalLight
                + priceRobes * countStudents;

            if (countStudents >= 6)
            {
                freeBelts = countStudents / 6;

            }
            double freeBeltsSum = countStudents - freeBelts;
            double realNumbers = priceBelts * freeBeltsSum;
            double totalSum = sabresPrice + realNumbers;

            if (totalSum <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalSum - amountMoney:F2}lv more.");
            }

        }
    }
}
