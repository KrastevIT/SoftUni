using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayCelebrations
{
    public class Engine
    {
        private List<Birthdates> birthdates;

        public Engine()
        {
            birthdates = new List<Birthdates>();
        }

        public void Run()
        {
            string[] inputArgs = Console.ReadLine().Split();

            while (inputArgs[0] != "End")
            {
                string nameType = inputArgs[0];

                if (nameType == "Citizen")
                {
                    string name = inputArgs[1];
                    int age = int.Parse(inputArgs[2]);
                    string id = inputArgs[3];
                    string birthdate = inputArgs[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);

                    birthdates.Add(citizen);
                }
                else if (nameType == "Pet")
                {
                    string name = inputArgs[1];
                    string birthdate = inputArgs[2];

                    Pet pet = new Pet(name, birthdate);

                    birthdates.Add(pet);
                }

                inputArgs = Console.ReadLine().Split();
            }

            string specificYear = Console.ReadLine();

            foreach (var birthdate in birthdates.Where(x => x.Birthdate.EndsWith(specificYear)))
            {
                Console.WriteLine(birthdate.Birthdate);
            }
        }
    }
}
