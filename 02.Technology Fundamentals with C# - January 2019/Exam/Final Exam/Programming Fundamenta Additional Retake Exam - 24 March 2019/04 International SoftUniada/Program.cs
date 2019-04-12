using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_International_SoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ");

            var countryAndPoints = new Dictionary<string, Dictionary<string, int>>();
            var pointsCountry = new Dictionary<string, int>();

            while (input[0] != "END")
            {
                string country = input[0];
                string name = input[1];
                int point = int.Parse(input[2]);

                if (!countryAndPoints.ContainsKey(country))
                {
                    countryAndPoints[country] = new Dictionary<string, int>();
                    pointsCountry[country] = 0;
                }
                if (!countryAndPoints[country].ContainsKey(name))
                {
                    countryAndPoints[country][name] = 0;
                }

                countryAndPoints[country][name] += point;
                pointsCountry[country] += point;

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var coutry in pointsCountry.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{coutry.Key}: {coutry.Value}");

                foreach (var kvp in countryAndPoints[coutry.Key])
                {
                    Console.WriteLine($" -- {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
