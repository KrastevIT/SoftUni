using System;


namespace _03.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string firsValut = Console.ReadLine();
            string secontValut = Console.ReadLine();

            double bgn = 1.00;
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            if (firsValut == "BGN" && secontValut == "USD")
            {
                Console.WriteLine($"{money / usd:F2} USD");
            }
            else if (firsValut == "BGN" && secontValut == "EUR")
            {
                Console.WriteLine($"{money / eur:F2} EUR");
            }
            else if (firsValut == "BGN" && secontValut == "GBP")
            {
                Console.WriteLine($"{money / gbp:F2} GBP");
            }
            else if (firsValut == "USD" && secontValut == "BGN")
            {
                Console.WriteLine($"{money * usd / bgn:F2} BGN");
            }
            else if (firsValut == "USD" && secontValut == "EUR")
            {
                Console.WriteLine($"{money * usd / eur:F2} EUR");
            }
            else if (firsValut == "USD" && secontValut == "GBP")
            {
                Console.WriteLine($"{money * usd / gbp:F2} GBP");
            }
            else if (firsValut == "EUR" && secontValut == "BGN")
            {
                Console.WriteLine($"{money * eur / bgn:F2} BGN");
            }
            else if (firsValut == "EUR" && secontValut == "USD")
            {
                Console.WriteLine($"{money * eur / usd:F2} USD");
            }
            else if (firsValut == "EUR" && secontValut == "GBP")
            {
                Console.WriteLine($"{money * eur / gbp:F2} GBP");
            }
            else if (firsValut == "GBP" && secontValut == "BGN")
            {
                Console.WriteLine($"{money * gbp / bgn:F2} BGN");
            }
            else if (firsValut == "GBP" && secontValut == "USD")
            {
                Console.WriteLine($"{money * gbp / usd:F2} USD");
            }
            else if (firsValut == "GBP" && secontValut == "EUR")
            {
                Console.WriteLine($"{money * gbp / eur:F2} EUR");
            }
        }
    }
}
