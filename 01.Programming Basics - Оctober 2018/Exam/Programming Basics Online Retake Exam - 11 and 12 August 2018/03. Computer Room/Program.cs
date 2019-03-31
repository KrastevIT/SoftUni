using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double hours = double.Parse(Console.ReadLine());
            double people = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double pricePeople = 0;
            double allSum = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (time == "day")
                {
                    pricePeople = 10.50;
                }
                else if (time == "night")
                {
                    pricePeople = 8.40;
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (time == "day")
                {
                    pricePeople = 12.60;
                }
                else if (time == "night")
                {
                    pricePeople = 10.20;
                }
            }

            if (people >= 4)
            {
                pricePeople *=  0.90;
            }
            if (hours >= 5)
            {
                pricePeople *= 0.50;
            }

            allSum = (pricePeople * people) * hours;


            Console.WriteLine($"Price per person for one hour: {pricePeople:F2}");
            Console.WriteLine($"Total cost of the visit: {allSum:F2}");
        }
    }
}
