using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryGrades = int.Parse(Console.ReadLine());

            string command = "";
            string name = "";
            int problem = 0;
            int evaluation = 0;
            double sumEvaluation = 0;
            int numberFall = 0;

            while (name != "Enough")
            {
                command = name;
                name = Console.ReadLine();
                if (name == "Enough")
                {
                    double allsum = sumEvaluation / problem;
                    Console.WriteLine($"Average score: {allsum:F2}");
                    Console.WriteLine($"Number of problems: {problem}");
                    Console.WriteLine($"Last problem: {command}");
                    break;
                }
                evaluation = int.Parse(Console.ReadLine());
                sumEvaluation = sumEvaluation + evaluation;
                problem++;
                if (evaluation <= 4)
                {
                    numberFall++;
                }

                if (numberFall >= unsatisfactoryGrades)
                {
                    Console.WriteLine($"You need a break, {unsatisfactoryGrades} poor grades.");
                    break;
                }
            }
        }
    }
}
