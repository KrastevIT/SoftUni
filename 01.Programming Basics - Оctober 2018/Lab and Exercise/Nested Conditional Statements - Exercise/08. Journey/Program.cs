using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double result = 0;
            string destination = "";
            string place = "";

            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        result = budget * 0.30;
                        destination = "Bulgaria";
                        place = "Camp";

                    }
                    else if (budget <= 1000 && budget > 100)
                    {
                        result = budget * 0.40;
                        destination = "Balkans";
                        place = "Camp";
                    }
                    else if (budget > 1000)
                    {
                        result = budget * 0.90;
                        destination = "Europe";
                        place = "Hotel";
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        result = budget * 0.70;
                        destination = "Bulgaria";
                        place = "Hotel";
                    }
                    else if (budget <= 1000 && budget > 100)
                    {
                        result = budget * 0.80;
                        destination = "Balkans";
                        place = "Hotel";
                    }
                    else if (budget > 1000)
                    {
                        result = budget * 0.90;
                        destination = "Europe";
                        place = "Hotel";
                    }
                    break;


            }
            Console.WriteLine($"Somewhere in {destination:F2}");
            Console.WriteLine($"{place} - {result:F2}");
        }
    }
}

