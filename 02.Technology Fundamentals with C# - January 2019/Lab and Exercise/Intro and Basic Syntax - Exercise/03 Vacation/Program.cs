using System;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;
            bool test = false;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            if (type == "Students" && person >= 30)
            {
                totalPrice = (person * price) * 0.85;
            }
            else if (type == "Business" && person >= 100)
            {
                person -= 10;
                totalPrice = person * price;
            }
            else if (type == "Regular" && person >= 10 && person <= 20)
            {
                totalPrice = (person * price) * 0.95;
            }
            else
            {
                Console.WriteLine($"Total price: {person * price:F2}");
                test = true;
            }
            if (test == false)
            {
                Console.WriteLine($"Total price: {totalPrice:F2}");

            }



        }
    }
}
