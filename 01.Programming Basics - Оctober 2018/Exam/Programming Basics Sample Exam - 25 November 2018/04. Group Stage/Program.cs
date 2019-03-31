using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            int allInsert = 0;
            int allReceive = 0;

            int score = 0;

            for (int i = 0; i < n; i++)
            {
                int insert = int.Parse(Console.ReadLine());
                int receive = int.Parse(Console.ReadLine());

                allInsert += insert;
                allReceive += receive;

                if (insert > receive)
                {
                    score += 3;
                }
                else if (insert == receive)
                {
                    score++;
                }
            }

            if (allInsert >= allReceive)
            {
                Console.WriteLine($"{name} has finished the group phase with {score} points.");
            }
            else
            {
                Console.WriteLine($"{name} has been eliminated from the group phase.");
            }

            Console.WriteLine($"Goal difference: {allInsert - allReceive}.");
        }
    }
}
