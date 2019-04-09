using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            var gamePlusDLC = new Dictionary<string, decimal>();
            var gamePlusPrice = new Dictionary<string, decimal>();

            foreach (var item in input)
            {
                if (item.Contains(":"))
                {
                    string[] splitGameAndDLC = item.Split(":");
                    string game = splitGameAndDLC[0];
                    string dlc = splitGameAndDLC[1];

                    if (gamePlusPrice.ContainsKey(game) && !gamePlusDLC.ContainsKey(game))
                    {
                        decimal price = gamePlusPrice.First(x => x.Key == game).Value;
                        price *= 1.20m;

                        gamePlusDLC.Add($"{game} - {dlc}", price);
                        gamePlusPrice.Remove(game);
                    }
                }
                else if (item.Contains("-"))
                {
                    string[] splitGameAndPrice = item.Split('-');
                    string game = splitGameAndPrice[0];
                    decimal price = decimal.Parse(splitGameAndPrice[1]);

                    if (!gamePlusPrice.ContainsKey(game) && !gamePlusDLC.ContainsKey(game))
                    {
                        gamePlusPrice.Add(game, price);
                    }
                }
            }

            foreach (var game in gamePlusDLC.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {(game.Value * 0.5m):F2}");
            }

            foreach (var game in gamePlusPrice.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {(game.Value * 0.80m):F2}");
            }
        }
    }
}
