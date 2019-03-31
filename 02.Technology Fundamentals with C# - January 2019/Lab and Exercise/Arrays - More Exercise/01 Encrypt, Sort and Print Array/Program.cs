using System;
using System.Linq;

namespace _01_Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLimit = int.Parse(Console.ReadLine());

            int[] arrNumbers = new int[inputLimit];

            string vowels = "aAeEiIoOuU";
            char[] vowelArr = vowels.ToCharArray();
            string consonants = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXzZyY";
            char[] consonantsArr = consonants.ToCharArray();

            for (int i = 0; i < inputLimit; i++)
            {
                string word = Console.ReadLine();
                char[] letters = word.ToCharArray();

                int sum = 0;

                for (int j = 0; j < letters.Length; j++)
                {
                    char currentChar = letters[j];

                    if (vowelArr.Contains(currentChar))
                    {
                        sum += letters[j] * letters.Length;
                    }
                    else
                    {
                        sum += letters[j] / letters.Length;
                    }
                }

                arrNumbers[i] = sum;
            }

            Array.Sort(arrNumbers);

            foreach (var item in arrNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
