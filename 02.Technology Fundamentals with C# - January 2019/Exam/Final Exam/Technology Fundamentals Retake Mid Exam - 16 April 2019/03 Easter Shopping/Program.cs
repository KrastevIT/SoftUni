using System;
using System.Collections.Generic;

namespace _03_Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var shops = new List<string>(input);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Include")
                {
                    shops.Add(command[1]);
                }
                else if (command[0] == "Visit")
                {
                    string commShop = command[1];
                    int index = int.Parse(command[2]);

                    if (index <= shops.Count)
                    {
                        if (commShop == "first")
                        {
                            for (int k = 0; k < index; k++)
                            {
                                shops.RemoveAt(0);
                            }
                        }
                        else if (commShop == "last")
                        {
                            for (int m = 0; m < index; m++)
                            {
                                shops.RemoveAt(shops.Count - 1);
                            }
                        }
                    }
                }
                else if (command[0] == "Prefer")
                {
                    int firstShop = int.Parse(command[1]);
                    int secondShop = int.Parse(command[2]);

                    if (shops.Count > firstShop && shops.Count > secondShop)
                    {
                        string firsName = shops[firstShop];
                        string secondName = shops[secondShop];

                        shops.RemoveAt(firstShop);
                        shops.Insert(firstShop, secondName);

                        shops.RemoveAt(secondShop);
                        shops.Insert(secondShop, firsName);
                    }

                }
                else if (command[0] == "Place")
                {
                    string NameShop = command[1];
                    int index = int.Parse(command[2])+1;

                    if (shops.Count > index)
                    {
                        shops.Insert(index, NameShop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
