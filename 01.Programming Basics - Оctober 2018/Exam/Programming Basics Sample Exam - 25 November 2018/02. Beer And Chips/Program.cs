using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int countOfBeers = int.Parse(Console.ReadLine());
            int countOfChips = int.Parse(Console.ReadLine());

            double moneyForBeers = countOfBeers * 1.20;
            double moneyForCheeps = moneyForBeers * 0.45;
            double cheepses = moneyForCheeps * countOfChips;

            double all = moneyForBeers + Math.Ceiling(cheepses);

            if (budget >= all)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - all):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(all - budget):F2} more leva!");
            }
        }
    }
}
