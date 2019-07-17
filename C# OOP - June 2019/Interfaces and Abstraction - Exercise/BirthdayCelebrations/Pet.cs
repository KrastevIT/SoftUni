using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : Birthdates
    {
        private string name;

        public Pet(string name, string birthdate)
            : base(birthdate)
        {
            this.name = name;
        }
    }
}
