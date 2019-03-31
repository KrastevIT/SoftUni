using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int allSteps = 0;
            int krachki = 0;

            while (allSteps < 10000)
            {
                if (steps != "Going home")
                {
                    krachki = int.Parse(steps);
                    allSteps += krachki;
                    if (allSteps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    steps = Console.ReadLine();
                }
                else
                {
                    steps = Console.ReadLine();
                    krachki = int.Parse(steps);
                    allSteps += krachki;

                    if (allSteps < 10000)
                    {
                        allSteps = 10000 - allSteps;
                        Console.WriteLine("{0} more steps to reach goal.", allSteps);
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                    break;
                }
            }
        }
    }
}
