using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupVolume = int.Parse(Console.ReadLine());
            int counter = 0;
            int overallVolume = 0;
            int volume = 0;

            string buttons;

            while ((buttons = Console.ReadLine()) != null && overallVolume < cupVolume)
            {

                switch (buttons)
                {
                    case "Easy":

                        volume = 50;
                        break;
                    case "Medium":
                        volume = 100;
                        break;
                    case "Hard":

                        volume = 200;
                        break;
                }
                overallVolume += volume;

                counter++;

            }

            if (overallVolume > cupVolume)
            {
                int spiltWater = overallVolume - cupVolume;
                Console.WriteLine($"{spiltWater}ml has been spilled.");
            }
            else
            {
                Console.WriteLine($"The dispenser has been tapped {counter} times.");
            }

        }
    }
}
