using System;

namespace _01_Bonus_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double currentBonus = 0;
            double maxBonus = 0;
            double attendedLectures = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                double attendancesOfStudent = double.Parse(Console.ReadLine());

                currentBonus = attendancesOfStudent / countOfLectures * (5+ bonus);
         
                if (attendancesOfStudent > attendedLectures)
                {
                    maxBonus = currentBonus;
                    attendedLectures = attendancesOfStudent;
                }
            }

            Console.WriteLine($"The maximum bonus score for this course is {Math.Round(maxBonus)}.The student has attended {attendedLectures} lectures.");
        }
    }
}
