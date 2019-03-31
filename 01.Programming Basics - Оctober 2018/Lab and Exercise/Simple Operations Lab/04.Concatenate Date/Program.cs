using System;


namespace _04.Concatenate_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string firsName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firsName, lastName, age, town);
        }
    }
}
