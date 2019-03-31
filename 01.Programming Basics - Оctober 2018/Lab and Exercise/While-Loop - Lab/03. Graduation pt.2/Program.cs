using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double sum = 0;
            int broken = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum = sum + grade;
                    counter++;
                }
                else
                {
                    broken++;
                    if (broken > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        break;
                    }

                }

            }
            if (broken < 1)
            {
                double average = sum / 12;

                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}
