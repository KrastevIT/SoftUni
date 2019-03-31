using System;

namespace _06_Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool bracketTest = false;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                string bracket = Console.ReadLine();

                if (bracket == "(")
                {
                    bracketTest = false;
                    counter++;

                }
                if (bracket == ")" && counter == 1)
                {
                    bracketTest = true;
                    counter = 0;
                }
            }

            if (bracketTest)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
