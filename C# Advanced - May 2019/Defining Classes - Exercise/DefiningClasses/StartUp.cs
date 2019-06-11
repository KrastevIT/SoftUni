using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int familyMemberscount = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();

            for (int i = 0; i < familyMemberscount; i++)
            {
                string[] memberData = Console.ReadLine().Split();

                string memberName = memberData[0];
                int memberAge = int.Parse(memberData[1]);

                people.Add(memberName, memberAge);

            }

            PrintSortedPeople(people);
        }

        private static void PrintSortedPeople(Dictionary<string, int> people)
        {
            foreach (var kvp in people
                .Where(x => x.Value > 30)
                .OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
