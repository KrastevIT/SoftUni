using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();  
            int numberOfNights = int.Parse(Console.ReadLine()); 

            double priceApart = 0.0;
            double priceStudio = 0.0;

            switch (month)
            {
                case "May":
                case "October":

                    if (numberOfNights > 14)
                    {
                        priceApart = numberOfNights * 65.0 * 0.9;
                        priceStudio = numberOfNights * 50.0 * 0.7;
                    }
                    else if (numberOfNights > 7)
                    {
                        priceStudio = numberOfNights * 50.0 * 0.95;
                        priceApart = numberOfNights * 65.0;
                    }
                    else
                    {
                        priceApart = numberOfNights * 65.0;
                        priceStudio = numberOfNights * 50.0;
                    }
                    break;

                case "June":
                case "September":

                    if (numberOfNights > 14)
                    {
                        priceApart = numberOfNights * 68.70 * 0.9;
                        priceStudio = numberOfNights * 75.20 * 0.8;
                    }
                    else
                    {
                        priceApart = numberOfNights * 68.70;
                        priceStudio = numberOfNights * 75.20;
                    }
                    break;

                case "July":
                case "August":
                    priceStudio = numberOfNights * 76.0;

                    if (numberOfNights > 14)
                    {
                        priceApart = numberOfNights * 77 * 0.9;
                    }
                    else
                    {
                        priceApart = numberOfNights * 77.0;
                    }
                    break;
            }

            Console.WriteLine("Apartment: {0:f2} lv.", priceApart);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);

        }
    }
}


