using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            double up = 0;
            double down = 0;
            double verifiers = 0;
            double allSum = 0;

            for (int i = 1; i <= stops; i++)
            {
                down = double.Parse(Console.ReadLine());
                up = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    verifiers += 2;
                    if (i <= 1)
                    {
                        allSum = (passengers - down) + up + verifiers;
                        continue;
                    }
                    allSum = (allSum - down) + up + verifiers;

                }
                else if (i % 2 == 0)
                {
                    allSum = (allSum - down) + up - verifiers;
                    verifiers -= 2;
                }

            }
            Console.WriteLine($"The final number of passengers is: {allSum}.");

        }
    }
}
