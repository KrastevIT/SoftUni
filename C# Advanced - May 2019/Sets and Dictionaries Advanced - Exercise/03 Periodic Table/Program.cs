using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputChemical = Console.ReadLine().Split();

                for (int k = 0; k < inputChemical.Length; k++)
                {
                    if (!elements.Contains(inputChemical[k]))
                    {
                        elements.Add(inputChemical[k]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
        }
    }
}
