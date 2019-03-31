using System;

namespace _04_Password_Validator
{
    class Program
    {
        static bool sixToTen = false;
        static bool lattersAndDigit = false;
        static bool twoDigit = false;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();



            ValidFromSixToTenSymbols(input);
            ValidOnlyLettersAndDigits(input);
            ValidHaveLeastTwoDigits(input);

            if (sixToTen == true)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (lattersAndDigit == true)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (twoDigit == true)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (sixToTen == false && lattersAndDigit == false && twoDigit == false)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static void ValidHaveLeastTwoDigits(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                twoDigit = false;
            }
            else
            {
                twoDigit = true;
            }
        }

        private static void ValidOnlyLettersAndDigits(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetterOrDigit(input[i]))
                {
                    lattersAndDigit = false;
                }
                else
                {
                    lattersAndDigit = true;
                    break;
                }

            }
        }

        private static void ValidFromSixToTenSymbols(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                sixToTen = false;
            }
            else
            {
                sixToTen = true;
            }

        }
    }
}