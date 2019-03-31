using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            double priceOfWash = double.Parse(Console.ReadLine());
            double priceOfToy = int.Parse(Console.ReadLine());

            double startMoney = 0;
            double sumOfMoney = 0;
            double toy = 0;
            double get = 0;

            for (int i = 1; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    startMoney += 10;
                    sumOfMoney += startMoney;
                    get++;
                }
                else if (i % 2 == 1)
                {
                    toy++;
                }
            }
            double toyPrice = toy * priceOfToy;
            double ollSum = sumOfMoney + toyPrice - get;

            if (ollSum >= priceOfWash)
            {
                double ostatak = ollSum - priceOfWash;
                Console.WriteLine($"Yes! {ostatak:F2}");
            }
            else
            {
                double nedostigat = priceOfWash - ollSum;
                Console.WriteLine($"No! {nedostigat:F2}");
            }
        }
    }
}
