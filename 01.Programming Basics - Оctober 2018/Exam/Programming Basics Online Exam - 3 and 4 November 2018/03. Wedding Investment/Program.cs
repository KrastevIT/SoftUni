using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wedding_Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            string termContract = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string dessert = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double tax = 0;
            double price = 0;

            if (termContract == "one")
            {
                if (typeContract == "Small")
                {
                    tax = 9.98;
                }
                else if (typeContract == "Middle")
                {
                    tax = 18.99;
                }
                else if (typeContract == "Large")
                {
                    tax = 25.98;
                }
                else if (typeContract == "ExtraLarge")
                {
                    tax = 35.99;
                }
            }
            if (termContract == "two")
            {
                if (typeContract == "Small")
                {
                    tax = 8.58;
                }
                else if (typeContract == "Middle")
                {
                    tax = 17.09;
                }
                else if (typeContract == "Large")
                {
                    tax = 23.59;
                }
                else if (typeContract == "ExtraLarge")
                {
                    tax = 31.79;
                }
            }

            if (dessert == "yes")
            {
                if (tax <= 10)
                {
                    price = tax + 5.50;
                }
                else if (tax <= 30 && tax > 10)
                {
                    price = tax + 4.35;
                }
                else if (tax > 30)
                {
                    price = tax + 3.85;
                }

            }
            if (dessert == "no")
            {
                price = tax;
            } 

            if (termContract == "two")
            {
                price = price * 0.9625;
                Console.WriteLine($"{price* months:F2} lv.");
            }
            else
            {
                Console.WriteLine($"{price * months:F2} lv.");
            }
        }
    }
}
