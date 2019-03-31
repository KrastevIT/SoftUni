using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            string vidApartament = Console.ReadLine();
            string ocenka = Console.ReadLine();

            double roomPerson = 18.00;
            double apartament = 25.00;
            double presidentApartment = 35.00;

            double allSum = 0;


            if (vidApartament == "room for one person")
            {
                allSum = (dni - 1) * roomPerson;
            }
            else if (vidApartament == "apartment")
            {
                if (dni < 10)
                {
                    allSum = (dni - 1) * apartament;
                    allSum = allSum * 0.70;
                }
                else if (dni >= 10 && dni <= 15)
                {
                    allSum = (dni - 1) * apartament;
                    allSum = allSum * 0.65;
                }
                else if (dni > 15)
                {
                    allSum = (dni - 1) * apartament;
                    allSum = allSum * 0.50;
                }
            }
            else if (vidApartament == "president apartment")
            {
                if (dni < 10)
                {
                    allSum = (dni - 1) * presidentApartment;
                    allSum = allSum * 0.90;
                }
                else if (dni >= 10 && dni <= 15)
                {
                    allSum = (dni - 1) * presidentApartment;
                    allSum = allSum * 0.85;
                }
                else if (dni > 15)
                {
                    allSum = (dni - 1) * presidentApartment;
                    allSum = allSum * 0.80;
                }
            }

            if (ocenka == "positive")
            {
                allSum = (allSum * 0.25) + allSum;
            }
            else
            {
                allSum = allSum * 0.90;
            }
            Console.WriteLine($"{allSum:F2}");
        }
    }
}
