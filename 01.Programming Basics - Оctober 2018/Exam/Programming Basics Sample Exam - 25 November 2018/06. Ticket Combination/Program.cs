using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int index = 0;

            for (char i = 'B'; i <= 'L'; i++)
            {
                for (char l = 'f'; l >= 'a'; l--)
                {
                    for (char k = 'A'; k <= 'C'; k++)
                    {
                        for (int p = 1; p <= 10; p++)
                        {
                            for (int f = 10; f >= 1; f--)
                            {
                                if (i % 2 == 0)
                                {
                                    index++;
                                    if (index == counter)
                                    {
                                        double prize = i + l + k + p + f;
                                        string combination = $"{i}{l}{k}{p}{f}";
                                        Console.WriteLine($"Ticket combination: {combination}");
                                        Console.WriteLine($"Prize: {prize} lv.");
                                    }
                                    
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
