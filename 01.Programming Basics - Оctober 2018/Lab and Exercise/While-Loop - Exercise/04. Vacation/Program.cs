using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int needMoney = int.Parse(Console.ReadLine());
            int amountSum = int.Parse(Console.ReadLine());

            double residue = 0;
            int daysGone = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                daysGone++;

                if (action == "spend")
                {
                    residue = amountSum - sum;
                }
                if (amountSum <= sum)
                {
                    residue = 0;
                }
                if (action == "save")
                {
                    residue = residue + sum;
                }
                if (residue >= needMoney)
                {
                    Console.WriteLine($"You saved the money for {daysGone} days.");
                }
                else if (daysGone >= 5)
                {
                    Console.WriteLine($"You can't save the money. {daysGone}");
                }

            }
        }
    }
}
