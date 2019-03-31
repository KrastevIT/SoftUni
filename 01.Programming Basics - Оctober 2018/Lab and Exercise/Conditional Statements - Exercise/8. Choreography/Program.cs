using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double dailySteps = (steps / days) / steps * 100;
            dailySteps = Math.Ceiling(dailySteps);
            double stepsPerDancer = dailySteps / dancers;

            if (dailySteps <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer}%.");
            }
            else if (dailySteps > 13)
            {
                double sum = dailySteps / dancers;
                Console.WriteLine($"No, They will not succeed in that goal! Required {sum:F2}% steps to be learned per day.");
            }
        }
    }
}
