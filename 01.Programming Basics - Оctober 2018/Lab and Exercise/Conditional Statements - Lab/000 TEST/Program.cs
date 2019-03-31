using System;


namespace _2.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine().ToLower();
            string destMetric = Console.ReadLine().ToLower();

            if (sourceMetric == "mm")
                size = size / 1000;
            else if(sourceMetric == "cm")
                size = size / 100;
            else if (sourceMetric == "mi")
                size = size / 0.000621371192;
            else if (sourceMetric == "in")
                size = size / 39.3700787;
            else if (sourceMetric == "km")
                size = size / 0.001;
            else if (sourceMetric == "ft")
                size = size / 3.2808399;
            else if (sourceMetric == "yd")
                size = size / 1.0936133;

            if (sourceMetric == "mm")
                size = size * 1000;
            else if (sourceMetric == "cm")
                size = size * 100;
            else if (sourceMetric == "mi")
                size = size * 0.000621371192;
            else if (sourceMetric == "in")
                size = size * 39.3700787;
            else if (sourceMetric == "km")
                size = size * 0.001;
            else if (sourceMetric == "ft")
                size = size * 3.2808399;
            else if (sourceMetric == "yd")
                size = size * 1.0936133;

            Console.WriteLine(size);

        }


    }
}
