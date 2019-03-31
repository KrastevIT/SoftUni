using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            string[] command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "course start")
            {
                string leftCommand = command[0];
                string lesson = command[1];

                if (leftCommand == "Add")
                {
                    if (!input.Contains(lesson))
                    {
                        input.Add(lesson);
                    }
                }
                else if (leftCommand == "Insert")
                {
                    int index = int.Parse(command[2]);

                    if (!input.Contains(lesson))
                    {
                        input.Insert(index, lesson);
                    }
                }
                else if (leftCommand == "Remove")
                {
                    if (input.Contains(lesson))
                    {
                        input.Remove(lesson);
                        string secondLesson = command[1];

                        if (input.Contains(secondLesson + "-Exercise"))
                        {
                            string exercise = $"{secondLesson}-Exercise";
                            int index = input.IndexOf(exercise);
                            input.RemoveAt(index);
                        }
                    }
                }
                else if (leftCommand == "Swap")
                {
                    string secondLesson = command[2];

                    if (input.Contains(lesson) && input.Contains(secondLesson))
                    {
                        int firstIndex = input.IndexOf(lesson);
                        int secondIndex = input.IndexOf(secondLesson);

                        input.RemoveAt(firstIndex);
                        input.RemoveAt(secondIndex - 1);
                        input.Insert(firstIndex, secondLesson);
                        input.Insert(secondIndex, lesson);

                        if (input.Contains(secondLesson + "-Exercise"))
                        {
                            input.Insert(firstIndex + 1, input[input.Count - 1]);
                            input.RemoveAt(input.Count - 1);
                        }
                    }

                }
                else if (leftCommand == "Exercise")
                {
                    string exercise = $"{lesson}-{leftCommand}";

                    if (!input.Contains(lesson))
                    {
                        input.Add(lesson);
                        input.Add(exercise);
                    }
                    else if (input.Contains(lesson))
                    {
                        if (!input.Contains(exercise))
                        {
                            int index = input.IndexOf(lesson);
                            input.Insert(index + 1, exercise);
                        }
                    }
                }


                command = Console.ReadLine().Split(':');
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
