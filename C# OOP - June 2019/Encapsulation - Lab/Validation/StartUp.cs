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

            List<Person> people = new List<Person>();

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

                    people.Add(person);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            foreach (var person in people)
            {
                person.IncreaseSalary(percentage);

                Console.WriteLine(person);
            }
        }
    }
}
