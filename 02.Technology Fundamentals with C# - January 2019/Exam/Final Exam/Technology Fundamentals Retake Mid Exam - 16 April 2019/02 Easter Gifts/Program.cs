using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var gifts = new List<string>(input);

            string[] command = Console.ReadLine().Split("",StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "No")
            {
                string comm = command[0];

                if (comm == "OutOfStock")
                {
                    string gift = command[1];

                    if (gifts.Contains(gift))
                    {
                        var indexOf = new List<int>();

                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if (gifts[i] == gift)
                            {
                                indexOf.Add(i);
                            }
                        }

                        foreach (var item in indexOf)
                        {
                            gifts.RemoveAt(item);
                            gifts.Insert(item, "None");
                        }
                    }
                }
                else if (comm == "Required")
                {
                    string gift = command[1];
                    int index = int.Parse(command[2]);



                    if (gifts.Count > index)
                    {
                        if (gifts[index] == "None")
                        {
                            continue;
                        }
                        gifts.RemoveAt(index);
                        gifts.Insert(index, gift);
                    }
                }
                else if (comm == "JustInCase")
                {
                    string gift = command[1];

                    if (gifts[gifts.Count - 1] == "None")
                    {
                        continue;
                    }
                    gifts.RemoveAt(gifts.Count - 1);
                    gifts.Add(gift);
                }

                command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in gifts)
            {
                if (item != "None")
                {
                    Console.Write($"{item + " "}");
                }
            }

        }
    }
}
