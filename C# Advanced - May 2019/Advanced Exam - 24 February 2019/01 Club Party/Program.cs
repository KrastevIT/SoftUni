using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            string[] lettersAndDigits = Console.ReadLine().Split();

            var stack = new Stack<string>(lettersAndDigits);

            var hall = new Queue<string>();

            var people = new List<string>();

            int currentCapacity = 0;

            while (stack.Any())
            {
                string element = stack.Pop();

                bool isNumber = int.TryParse(element, out int number);

                if (isNumber)
                {
                    if (!hall.Any())
                    {
                        continue;
                    }

                    if (currentCapacity + number > capacity)
                    {
                        Print(hall, people);

                        people.Clear();

                        currentCapacity = 0;
                    }

                    if (hall.Any())
                    {
                        people.Add(element);

                        currentCapacity += number;
                    }
                }
                else
                {
                    hall.Enqueue(element);
                }

            }
        }

        private static void Print(Queue<string> hall, List<string> people)
        {
            Console.WriteLine($"{hall.Dequeue()} -> {string.Join(", ", people)}");
        }
    }
}
