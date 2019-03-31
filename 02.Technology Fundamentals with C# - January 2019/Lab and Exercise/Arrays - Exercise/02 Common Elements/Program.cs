using System;

namespace _02_Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstElements = Console.ReadLine().Split();
            string[] secondElements = Console.ReadLine().Split();

            for (int i = 0; i < secondElements.Length; i++)
            {
                for (int k = 0; k < firstElements.Length; k++)
                {
                    if (secondElements[i] == firstElements[k])
                    {
                        Console.Write(secondElements[i] + " ");
                    }
                }
            }

        }
    }
}
