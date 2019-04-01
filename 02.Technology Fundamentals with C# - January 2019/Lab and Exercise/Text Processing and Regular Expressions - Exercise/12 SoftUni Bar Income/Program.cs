using System;
using System.Text.RegularExpressions;

namespace _12_SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patter = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*[|](?<count>\d+)[|][^|$%.]*?(?<price>\d+[.]?\d+)[$]";

            double totalSum = 0.00;

            while (input != "end of shift")
            {
                Regex order = new Regex(patter);

                if (order.IsMatch(input))
                {
                    string name = order.Match(input).Groups["name"].Value;
                    string product = order.Match(input).Groups["product"].Value;
                    int count = int.Parse(order.Match(input).Groups["count"].Value);
                    double price = double.Parse(order.Match(input).Groups["price"].Value);

                    double sum = count * price;
                    totalSum += sum;
                    Console.WriteLine($"{name}: {product} - {sum:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}
