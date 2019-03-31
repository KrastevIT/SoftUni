using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double counter199 = 0;
            double counter399 = 0;
            double counter599 = 0;
            double counter799 = 0;
            double counter800 = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number >= 1 && number < 200)
                {
                    counter199++;
                }
                else if (number >= 200 && number < 400)
                {
                    counter399++;
                }
                else if (number >= 400 && number < 600)
                {
                    counter599++;
                }
                else if (number >= 600 && number < 800)
                {
                    counter799++;
                }
                else
                {
                    counter800++;
                }
            }

            Console.WriteLine("{0:f2}%", (counter199 / n) * 100);
            Console.WriteLine("{0:f2}%", (counter399 / n) * 100);
            Console.WriteLine("{0:f2}%", (counter599 / n) * 100);
            Console.WriteLine("{0:f2}%", (counter799 / n) * 100);
            Console.WriteLine("{0:f2}%", (counter800 / n) * 100);
        }
    }
}
