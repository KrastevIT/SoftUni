using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Hello_France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split("|")
                .ToList();

            double budget = double.Parse(Console.ReadLine());

            List<string> newItems = new List<string>();

            double profit = 0;
            double needSum = 150;
            bool test = true;

            double clothes = 50.00;
            double shoes = 35.00;
            double accessories = 20.50;


            for (int i = 0; i < items.Count; i++)
            {
                string[] command = items[i].Split("->");
                string item = command[0];
                double sum = double.Parse(command[1]);

                if (item == "Clothes")
                {
                    if (budget >= sum && sum <= clothes)
                    {
                        budget -= sum;
                        newItems.Add(items[i]);
                    }

                }
                else if (item == "Shoes")
                {
                    if (budget >= sum && sum <= shoes)
                    {
                        budget -= sum;
                        newItems.Add(items[i]);
                    }
                }
                else if (item == "Accessories")
                {
                    if (budget >= sum && sum <= accessories)
                    {
                        budget -= sum;
                        newItems.Add(items[i]);
                    }
                }
                else if (budget >= sum)
                {
                    budget -= sum;
                    newItems.Add(items[i]);
                }
            }

            needSum -= budget;
            List<double> sellSum = new List<double>();
            double increase = 0;
            double testSum = 0;
            testSum += budget;

            for (int i = 0; i < newItems.Count; i++)
            {
                string[] command = newItems[i].Split("->");
                string item = command[0];
                double sum = double.Parse(command[1]);

                profit += sum * 0.40;
                increase = sum * 0.40;

                testSum += sum + increase;

                if (testSum > needSum)
                {
                    sellSum.Add(sum + increase);

                    foreach (var input in sellSum)
                    {
                        Console.Write($"{input:F2} ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Profit: {profit:F2}");
                    Console.WriteLine("Hello, France!");
                    test = false;
                    break;
                }
                else
                {
                    sellSum.Add(sum + increase);
                    
                }
            }

            double totalSum = sellSum.Sum();

            if (test)
            {
                Console.WriteLine(string.Join(" ", sellSum));
                Console.WriteLine($"Profit: {profit:F2}");
                Console.WriteLine("Time to go.");
            }

        }
    }
}
