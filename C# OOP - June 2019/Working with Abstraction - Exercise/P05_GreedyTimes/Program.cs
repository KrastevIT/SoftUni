using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            string[] safe = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();

            long gold = 0;
            long gem = 0;
            long gash = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];

                long quantity = long.Parse(safe[i + 1]);

                string item = string.Empty;

                item = SearchItem(name, item);

                if (item == "")
                {
                    continue;
                }
                else if (input < bag.Values.Select(x => x.Values.Sum()).Sum() + quantity)
                {
                    continue;
                }

                switch (item)
                {
                    case "Gem":
                        if (!bag.ContainsKey(item))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (quantity > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[item].Values.Sum() + quantity > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }

                        break;

                    case "Cash":
                        if (!bag.ContainsKey(item))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (quantity > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[item].Values.Sum() + quantity > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(item))
                {
                    bag[item] = new Dictionary<string, long>();
                }

                if (!bag[item].ContainsKey(name))
                {
                    bag[item][name] = 0;
                }

                bag[item][name] += quantity;

                if (item == "Gold")
                {
                    gold += quantity;
                }
                else if (item == "Gem")
                {
                    gem += quantity;
                }
                else if (item == "Cash")
                {
                    gash += quantity;
                }
            }

            foreach (var item in bag)
            {
                Console.WriteLine($"<{item.Key}> ${item.Value.Values.Sum()}");

                foreach (var kvp in item.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{kvp.Key} - {kvp.Value}");
                }
            }
        }

        private static string SearchItem(string name, string item)
        {
            if (name.Length == 3)
            {
                item = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                item = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                item = "Gold";
            }

            return item;
        }
    }
}