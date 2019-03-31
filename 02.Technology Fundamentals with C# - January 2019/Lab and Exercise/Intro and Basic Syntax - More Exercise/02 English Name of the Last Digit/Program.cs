using System;

namespace _02_English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = number %10;
            string name = "";

            if (newNumber == 1)
            {
                name = "one";
            }
            else if (newNumber == 2)
            {
                name = "two";
            }
            else if (newNumber == 3)
            {
                name = "three";
            }
            else if (newNumber == 4)
            {
                name = "four";
            }
            else if (newNumber == 5)
            {
                name = "five";
            }
            else if (newNumber == 6)
            {
                name = "six";
            }
            else if (newNumber == 7)
            {
                name = "seven";
            }
            else if (newNumber == 8)
            {
                name = "eight";
            }
            else if (newNumber == 9)
            {
                name = "nine";
            }
            else if (newNumber == 0)
            {
                name = "zero";
            }
            Console.WriteLine(name);
        }
    }
}
