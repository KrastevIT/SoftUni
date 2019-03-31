using System;
using System.Numerics;

namespace _08_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            PrintPowerNumber(number, pow);
            
        }

        static void PrintPowerNumber(double number, int powNumber)
        {
            double rezult =Math.Pow(number, powNumber);
            Console.WriteLine((decimal)rezult);
        }
    }
}
