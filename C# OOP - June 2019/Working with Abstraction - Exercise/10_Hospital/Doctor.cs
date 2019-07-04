using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Hospital
{
    public class Doctor
    {
        public Doctor(string department, string firstName, string lastName, List<Patient> patients)
        {
            Patients = new List<Patient>();

            Department = department;
            FirstName = firstName;
            LastName = lastName;
            Patients = patients;
        }

        public string Department { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Patient> Patients { get; set; }

    }
}
