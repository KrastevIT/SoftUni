using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_The_Party_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();

            List<string> filters = new List<string>();

            string filter = Console.ReadLine();

            while (filter != "Print")
            {
                string[] filterInfo = filter.Split(';');

                string action = filterInfo[0];

                if (action == "Add filter")
                {
                    filters.Add($"{filterInfo[1]};{filterInfo[2]}");
                }
                else if (action == "Remove filter")
                {
                    filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
                }

                filter = Console.ReadLine();
            }

            Func<string, int, bool> lengthFilter = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFilter = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endWithFilter = (name, param) => name.EndsWith(param);
            Func<string, string, bool> containsFilter = (name, param) => name.Contains(param);

            foreach (var currentFilter in filters)
            {
                string[] currentFilterInfo = currentFilter.Split(';');

                string action = currentFilterInfo[0];
                string param = currentFilterInfo[1];

                if (action == "Starts with")
                {
                    names = names.Where(name => !startsWithFilter(name, param)).ToArray();
                }
                else if (action == "Ends with")
                {
                    names = names.Where(name => !endWithFilter(name, param)).ToArray();
                }
                else if (action == "Length")
                {
                    int length = int.Parse(param);

                    names = names.Where(name => !lengthFilter(name, length)).ToArray();
                }
                else if (action == "Contains")
                {
                    names = names.Where(name => !containsFilter(name, param)).ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
