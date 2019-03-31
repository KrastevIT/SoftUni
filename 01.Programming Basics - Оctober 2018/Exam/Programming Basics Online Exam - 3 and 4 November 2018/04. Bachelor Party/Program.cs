using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumGuests = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int number = 0;
            double couvert = 0;
            double sum = 0;
            int numberGuests = 0;

            while (command != "The restaurant is full")
            {
                number = int.Parse(command);

                if (number < 5)
                {
                    couvert = number * 100;
                }
                else if (number >= 5)
                {
                    couvert = number * 70;
                }

                sum += couvert;
                numberGuests += number;
                command = Console.ReadLine();

            }

            if (sum >= sumGuests)
            {
                Console.WriteLine($"You have {numberGuests} guests and {sum - sumGuests:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {numberGuests} guests and {sum} leva income, but no singer.");
            }
        }
    }
}
