using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Birthdates
    {
        private string birthdate;

        public Birthdates(string birthdate)
        {
            this.Birthdate = birthdate;
        }

        public string Birthdate
        {
            get
            {
                return this.birthdate;
            }
            set
            {
                this.birthdate = value;
            }
        }
    }
}
