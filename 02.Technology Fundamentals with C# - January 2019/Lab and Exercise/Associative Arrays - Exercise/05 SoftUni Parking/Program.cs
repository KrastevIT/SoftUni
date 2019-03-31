using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var registerUserName = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] usernameAndLicenseNumber = Console.ReadLine().Split();

                string command = usernameAndLicenseNumber[0];

                if (command == "register")
                {
                    string username = usernameAndLicenseNumber[1];
                    string licenseNumber = usernameAndLicenseNumber[2];

                    if (!registerUserName.ContainsKey(username))
                    {
                        registerUserName[username] = licenseNumber;
                        Console.WriteLine($"{username} registered {licenseNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string username = usernameAndLicenseNumber[1];

                    if (registerUserName.ContainsKey(username))
                    {
                        registerUserName.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var kvp in registerUserName)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
