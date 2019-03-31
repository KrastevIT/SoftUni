using System;

namespace _10_Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = 0;

            for (int i = 1; i <= lostGame; i++)
            {
                if (i % 2 == 0)
                {
                    money += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    money += mousePrice;
                }
                if (i % 6 == 0)
                {
                    money += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    money += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
