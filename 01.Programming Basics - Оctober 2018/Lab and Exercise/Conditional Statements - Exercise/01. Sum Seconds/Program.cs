using System;


namespace _01.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int secondsSum = first + second + third;
            int minutes = secondsSum / 60;
            int seconds = secondsSum % 60;

            Console.WriteLine($"{minutes:0}:{seconds:00}");

            //////////////////////////////////////////////
            ///int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());
            //int third = int.Parse(Console.ReadLine());

            //double sum = first + second + third;

            //if (sum <= 59)
            //{
            //    Console.WriteLine($"0:{sum}");
            //}
            //else if (sum <= 119)
            //{
            //    Console.WriteLine($"1:0{sum - 60}");
            //}
            //else if (sum < 179)
            //{
            //    Console.WriteLine($"2:{sum - 120}");
            //}


        }

    }
}
