using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int allBooks = int.Parse(Console.ReadLine());

            int searches = 0;

            while (true)
            {
                string foundit = Console.ReadLine();
                searches++;

                if (foundit == bookName)
                {
                    Console.WriteLine($"You checked {searches - 1} books and found it.");
                    break;
                }
                else if (searches == allBooks)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {searches} books.");
                    break;
                }

            }


        }
    }
}
