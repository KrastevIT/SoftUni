using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jornal = Console.ReadLine().Split(", ").ToList();

            string[] command = Console.ReadLine().Split(" - ");

            while (command[0] != "Retire!")
            {
                string currentCommand = command[0];
                string quest = command[1];

                if (currentCommand == "Start")
                {
                    if (!jornal.Contains(quest))
                    {
                        jornal.Add(quest);
                    }
                }
                else if (currentCommand == "Complete")
                {
                    jornal.Remove(quest);
                }
                else if (currentCommand == "Side Quest")
                {
                    string[] sideQuest = quest.Split(":").ToArray();

                    if (jornal.Contains(sideQuest[0]))
                    {
                        int index = jornal.IndexOf(sideQuest[0]);

                        if (!jornal.Contains(sideQuest[1]))
                        {
                            jornal.Insert(index + 1, sideQuest[1]);
                        }
                    }
                }
                else if (currentCommand == "Renew")
                {
                    if (jornal.Contains(quest))
                    {
                        jornal.Remove(quest);
                        jornal.Add(quest);
                    }
                }

                command = Console.ReadLine().Split(" - ");
            }
            Console.WriteLine(String.Join(", ", jornal));
        }
    }
}
