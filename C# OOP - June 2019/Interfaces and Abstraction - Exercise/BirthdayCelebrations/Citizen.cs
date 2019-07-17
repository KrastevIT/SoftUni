using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : Birthdates
    {
        private string name;
        private int age;
        private string id;
        public Citizen(string name, int age, string id, string birthdate)
            : base(birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
}
