using System;
using System.Linq;

namespace _10_Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputArgs;

            while ((inputArgs = Console.ReadLine()) != "End")
            {
                string[] parameters = inputArgs.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string department = parameters[0];
                string firstNameDoctor = parameters[1];
                string lastNameDoctor = parameters[2];
                string patient = parameters[3];

                Doctor doctor = new Doctor(department, firstNameDoctor, lastNameDoctor, patient);
                
            }
        }
    }
}
