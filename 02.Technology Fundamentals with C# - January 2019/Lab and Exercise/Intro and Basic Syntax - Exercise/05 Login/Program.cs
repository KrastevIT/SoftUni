using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string correctPassword = "";

            for (int i = user.Length - 1; i >= 0; i--)
            {
                correctPassword += user[i];
            }

            int counter = 1;

            while (true)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword == correctPassword)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else if (counter == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break; ;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                counter++;


            }

        }
    }
}
