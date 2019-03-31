using System;

namespace _7.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "square") // Квадрат (дължина на страната му.)
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine(area);

            }
            else if (type == "rectangle") // Правоъгълник (дължините на страните му.)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine(area);

            }
            else if (type == "circle") // Кръг (радиусът на кръга.)
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine(area);

            }
            else if (type == "triangle") // Триъгълник (- дължината на страната му и дължината на височината към нея.)
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (a * h) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
