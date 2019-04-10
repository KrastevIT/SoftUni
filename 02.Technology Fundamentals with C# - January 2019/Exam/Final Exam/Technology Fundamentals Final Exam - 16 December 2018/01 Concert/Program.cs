using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var bandNameAndNumbers = new Dictionary<string, List<string>>();
            var timeOfGrups = new Dictionary<string, int>();

            int totalTime = 0;

            string input;
            while ((input = Console.ReadLine()) != "start of concert")
            {
                if (input.Contains("Add"))
                {
                    string[] splitName = input.Split("; ");
                    string bandName = splitName[1];
                    string[] name = splitName[2].Split(", ");

                    if (!bandNameAndNumbers.ContainsKey(bandName))
                    {
                        bandNameAndNumbers[bandName] = new List<string>();
                    }

                    foreach (var number in name)
                    {
                        if (!bandNameAndNumbers[bandName].Contains(number))
                        {
                            bandNameAndNumbers[bandName].Add(number);
                        }
                    }

                }
                else if (input.Contains("Play"))
                {
                    string[] splitName = input.Split("; ");
                    string bandName = splitName[1];
                    int time = int.Parse(splitName[2]);
                    totalTime += time;

                    if (!timeOfGrups.ContainsKey(bandName))
                    {
                        timeOfGrups[bandName] = 0;
                    }

                    timeOfGrups[bandName] += time;
                }
            }

            string finalLine = Console.ReadLine();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var kvp in timeOfGrups.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            foreach (var kvp in bandNameAndNumbers.OrderBy(x => x.Key))
            {
                if (kvp.Key == finalLine)
                {
                    Console.WriteLine(kvp.Key);

                    foreach (var number in kvp.Value)
                    {
                        Console.WriteLine($"=> {number}");
                    }
                }
            }
        }
    }
}
