using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());

            Team team = new Team("SoftUni");

            for (int i = 0; i < line; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                try
                {
                    string firstName = inputArgs[0];
                    string lastName = inputArgs[1];
                    int age = int.Parse(inputArgs[2]);
                    decimal salary = decimal.Parse(inputArgs[3]);

                    Person person = new Person(firstName, lastName, age, salary);

                    team.AddPlayer(person);

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");

            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
