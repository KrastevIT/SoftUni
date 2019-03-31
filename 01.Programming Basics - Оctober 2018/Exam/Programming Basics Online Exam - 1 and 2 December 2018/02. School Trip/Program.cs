using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.School_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberDays = double.Parse(Console.ReadLine());
            double leftFood = double.Parse(Console.ReadLine());
            double foodFirstDog = double.Parse(Console.ReadLine());
            double foodSecoundDog = double.Parse(Console.ReadLine());
            double foodThirdDog = double.Parse(Console.ReadLine());

            double one = numberDays * foodFirstDog;
            double two = numberDays * foodSecoundDog;
            double three = numberDays * foodThirdDog;

            double allFood = one + two + three;

            if (leftFood >= allFood)
            {
                Console.WriteLine($"{Math.Floor(leftFood - allFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood - leftFood)} more kilos of food are needed.");
            }

        }
    }
}
