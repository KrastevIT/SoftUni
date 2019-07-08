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

                string firstName = inputArgs[0];
                string lastName = inputArgs[1];
                int age = int.Parse(inputArgs[2]);

                Person person = new Person(firstName, lastName, age);

                people.Add(person);
            }

            foreach (var person in people
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
}
