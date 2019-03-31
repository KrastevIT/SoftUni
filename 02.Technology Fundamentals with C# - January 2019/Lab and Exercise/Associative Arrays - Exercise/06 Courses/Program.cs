using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCourse = new Dictionary<string, List<string>>();


            string[] command = Console.ReadLine().Split(" : ");

            while (command[0] != "end")
            {
                string courseName = command[0];
                string studentName = command[1];

                if (!listOfCourse.ContainsKey(courseName))
                {
                    listOfCourse[courseName] = new List<string>();
                    listOfCourse[courseName].Add(studentName);
                }
                else if (!listOfCourse[courseName].Contains(studentName))
                {
                    listOfCourse[courseName].Add(studentName);
                }

                command = Console.ReadLine().Split(" : ");
            }

            var resultCourses = listOfCourse.OrderByDescending(x => x.Value.Count).ToList();

            foreach (var kvp in resultCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                var resultStudents = kvp.Value.OrderBy(x => x).ToList();

                foreach (var student in resultStudents)
                {
                    Console.WriteLine($"-- {student}");
                }
            }


        }
    }
}
