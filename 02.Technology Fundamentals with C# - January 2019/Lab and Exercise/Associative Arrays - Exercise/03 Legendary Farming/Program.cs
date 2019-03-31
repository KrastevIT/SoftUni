using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            var quantityAndMeterial = new Dictionary<string, int>();
            quantityAndMeterial["shards"] = 0;
            quantityAndMeterial["fragments"] = 0;
            quantityAndMeterial["motes"] = 0;

            var junk = new Dictionary<string, int>();

            string item = string.Empty;
            bool isLegendaryItem = false;


            while (true)
            {
                for (int i = 0; i < input.Count; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string meterial = input[i + 1].ToLower();


                    if (meterial == "shards" || meterial == "fragments" || meterial == "motes")
                    {
                        if (!quantityAndMeterial.ContainsKey(meterial))
                        {
                            quantityAndMeterial[meterial] = quantity;
                        }
                        else
                        {
                            quantityAndMeterial[meterial] += quantity;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(meterial))
                        {
                            junk[meterial] = quantity;
                        }
                        else
                        {
                            junk[meterial] += quantity;
                        }
                    }

                    foreach (var kvp in quantityAndMeterial)
                    {
                        if (kvp.Value >= 250)
                        {
                            if (meterial == "shards")
                            {
                                item = "Shadowmourne";
                            }
                            else if (meterial == "fragments")
                            {
                                item = "Valanyr";
                            }
                            else if (meterial == "motes")
                            {
                                item = "Dragonwrath";
                            }

                            isLegendaryItem = true;
                            quantityAndMeterial[meterial] -= 250;
                            break;
                        }
                    }

                    if (isLegendaryItem)
                    {
                        break;
                    }
                }

                if (isLegendaryItem)
                {
                    break;
                }

                input = Console.ReadLine().Split().ToList();
            }



            Console.WriteLine($"{item} obtained!");

            foreach (var kvp in quantityAndMeterial
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk
                .OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
