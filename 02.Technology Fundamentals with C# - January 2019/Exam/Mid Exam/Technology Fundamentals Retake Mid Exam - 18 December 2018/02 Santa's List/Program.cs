using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> noisyKids = Console.ReadLine().Split('&').ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "Finished!")
            {
                if (command[0] == "Bad")
                {
                    if (!noisyKids.Contains(command[1]))
                    {
                        noisyKids.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Good")
                {
                    noisyKids.Remove(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    if (noisyKids.Contains(command[1]))
                    {
                        int indexOfKid = noisyKids.IndexOf(command[1]);
                        noisyKids.Remove(command[1]);
                        noisyKids.Insert(indexOfKid, command[2]);
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (noisyKids.Contains(command[1]))
                    {
                        noisyKids.Remove(command[1]);
                        noisyKids.Add(command[1]);
                    }
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(String.Join(", ", noisyKids));
        }
    }
}
