using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Dictionary<string, List<string>>();

            string[] command = Console.ReadLine().Split(" -> ");

            while (command[0] != "End")
            {
                string name = command[0];
                string id = command[1];

                if (!company.ContainsKey(name))
                {
                    company[name] = new List<string>();
                    company[name].Add(id);
                }
                else
                {
                    if (!company[name].Contains(id))
                    {
                        company[name].Add(id);
                    }
                }

                command = Console.ReadLine().Split(" -> ");
            }


            foreach (var kvp in company.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
