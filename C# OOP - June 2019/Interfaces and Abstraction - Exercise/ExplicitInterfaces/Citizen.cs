using ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.name = name;
            this.country = country;
            this.age = age;
        }

        public string name { get; set; }

        public string country { get; set; }

        public int age { get; set; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {name}";
        }

        string IPerson.GetName()
        {
            return $"{name}";
        }
    }
}
