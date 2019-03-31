using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentsAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAndGrades.ContainsKey(name))
                {
                    studentsAndGrades[name] = new List<double>();
                }

                studentsAndGrades[name].Add(grade);
            }

            foreach (var kvp in studentsAndGrades.Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }
        }
    }
}
