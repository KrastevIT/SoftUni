using System;

namespace _01_Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int chistmasSpirit = 0;
            double budget = 0;

            double ornamentSet = 2.00;
            double treeSkirt = 5.00;
            double treeGarlands = 3.00;
            double treeLights = 15.00;

            bool buySirtandGatlands = false;
            int finalIndex = 0;



            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    budget += quantity * ornamentSet;
                    chistmasSpirit += 5;
                }
                if (i % 3 == 0)
                {
                    budget += quantity * treeSkirt;
                    budget += quantity * treeGarlands;
                    chistmasSpirit += 13;
                    buySirtandGatlands = true;
                }
                if (i % 5 == 0)
                {
                    budget += quantity * treeLights;
                    chistmasSpirit += 17;

                    if (buySirtandGatlands)
                    {
                        chistmasSpirit += 30;
                    }
                }

                buySirtandGatlands = false;

                if (i % 10 == 0)
                {
                    chistmasSpirit -= 20;
                    budget += treeSkirt + treeGarlands + treeLights;
                }

                finalIndex = i;
            }

            if (finalIndex % 10 == 0)
            {
                chistmasSpirit -= 30;
            }

            Console.WriteLine($"Total cost: {budget}");
            Console.WriteLine($"Total spirit: {chistmasSpirit}");
        }
    }
}
