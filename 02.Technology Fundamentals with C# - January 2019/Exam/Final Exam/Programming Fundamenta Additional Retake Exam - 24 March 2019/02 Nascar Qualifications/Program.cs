using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Nascar_Qualifications
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split();

            var pilots = new List<string>(name);

            string[] input = Console.ReadLine().Split();
            while (input[0] != "end")
            {
                string command = input[0];
                string racer = input[1];

                if (command == "Race")
                {
                    if (!pilots.Contains(racer))
                    {
                        pilots.Add(racer);
                    }
                }
                else if (command == "Accident")
                {
                    if (pilots.Contains(racer))
                    {
                        pilots.Remove(racer);
                    }
                }
                else if (command == "Box")
                {
                    if (pilots.Contains(racer))
                    {
                        int index = pilots.IndexOf(racer);
                        if (index == pilots.Count)
                        {
                            continue;
                        }
                        pilots.RemoveAt(index);
                        pilots.Insert(index + 1, racer);
                    }
                }
                else if (command == "Overtake")
                {
                    int position = int.Parse(input[2]);

                    if (pilots.Contains(racer))
                    {
                        int index = pilots.IndexOf(racer);

                        if (index +1 - position > 0)
                        {
                            pilots.RemoveAt(index);
                            pilots.Insert(index - position, racer);
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }


            Console.WriteLine(String.Join(" ~ ", pilots));


        }
    }
}
