using System;

namespace _01_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int msgNumber = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};

            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] autors = { "Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva"};

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random number = new Random();

            for (int i = 0; i < msgNumber; i++)
            {
                int phrasesIndex = number.Next(phrases.Length);
                int eventIndex = number.Next(events.Length);
                int autorsIndex = number.Next(autors.Length);
                int citiesIndex = number.Next(cities.Length);

                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventIndex]} {autors[autorsIndex]} – {cities[citiesIndex]}");
            }
        }
    }
}
