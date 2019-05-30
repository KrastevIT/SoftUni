using System;
using System.Collections.Generic;

namespace _01_Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var uniqueUsernames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string inputName = Console.ReadLine();

                if (!uniqueUsernames.Contains(inputName))
                {
                    uniqueUsernames.Add(inputName);
                }
            }

            foreach (var userName in uniqueUsernames)
            {
                Console.WriteLine(userName);
            }

        }
    }
}
