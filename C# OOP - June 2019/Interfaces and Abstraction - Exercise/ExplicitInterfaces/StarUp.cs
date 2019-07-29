using ExplicitInterfaces.Contracts;
using System;

namespace ExplicitInterfaces
{
    class StarUp
    {
        static void Main(string[] args)
        {
            string[] inputArgs = Console.ReadLine().Split();

            while (inputArgs[0] != "End")
            {
                string name = inputArgs[0];
                string country = inputArgs[1];
                int age = int.Parse(inputArgs[2]);

                Citizen citizen = new Citizen(name, country, age);

                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());

                inputArgs = Console.ReadLine().Split();
            }
        }
    }
}
