using System;
using System.Linq;

namespace _01_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                bool isValid = false;

                if (word.Length >= 3 && word.Length <= 16)
                {
                    for (int k = 0; k < word.Length; k++)
                    {
                        if (char.IsLetterOrDigit(word[k]) || word[k] == '-' || word[k] == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
