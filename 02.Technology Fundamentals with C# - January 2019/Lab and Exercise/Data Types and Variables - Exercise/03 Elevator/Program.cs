using System;

namespace _03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int numberOfCapacity = int.Parse(Console.ReadLine());

            double course = (double)numberOfPeople / numberOfCapacity;
            Console.WriteLine($"{(Math.Ceiling(course))}");
        }
    }
}
