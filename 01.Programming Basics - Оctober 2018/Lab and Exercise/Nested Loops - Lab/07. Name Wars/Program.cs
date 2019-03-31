using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string winner = "";
            int winnerPoint = 0;

            while (command != "STOP")
            {
                int sumOfName = 0;
                for (int i = 0; i < command.Length; i++)
                {
                    int symbol = command[i];
                    sumOfName += symbol;
                }

                if (sumOfName > winnerPoint)
                {
                    winnerPoint = sumOfName;
                    winner = command;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winner} - {winnerPoint}!");
        }
    }
}
