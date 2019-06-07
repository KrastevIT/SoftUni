using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] inputNames = Console.ReadLine()
                .Split()
                .ToArray();

            var listOfNames = new List<string>();

            Func<int, string, bool> lengthFilter = (length, name)
                => name.Length <= length;

            foreach (var currentName in inputNames)
            {
                if (lengthFilter(n, currentName))
                {
                    listOfNames.Add(currentName);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfNames));

        }
    }
}
