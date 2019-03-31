using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Going_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            double gasolineConsumption = double.Parse(Console.ReadLine());
            double priceGasoline = double.Parse(Console.ReadLine());
            double earMoney = double.Parse(Console.ReadLine());

            double cost = kilometers * gasolineConsumption / 100;
            double allCost = cost * priceGasoline;

            if (allCost <= earMoney)
            {
                Console.WriteLine($"You can go home. {Math.Abs(allCost - earMoney):F2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {earMoney / 5:F2} money.");
            }
        }
    }
}
