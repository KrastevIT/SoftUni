﻿using System;

namespace _01_Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = 0;

            for (int i = 1; i <= days; i++)
            {

                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                coins += 50;
                coins -= partySize * 2;

                if (i % 3 == 0)
                {
                    coins -= partySize * 3;
                }
                if (i % 5 == 0)
                {

                    coins += partySize * 20;
                    if (i % 3 == 0)
                    {
                        coins -= partySize * 2;
                    }
                }
            }

            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}
