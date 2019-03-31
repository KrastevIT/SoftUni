using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int smaller = int.Parse(Console.ReadLine());
            int bigger = int.Parse(Console.ReadLine());

            for (int i = smaller; i <= bigger; i++)
            {
                string num = i.ToString();
                int length = num.Length;

                int evenSum = 0;
                int oddSum = 0;
                int process = i;


                for (int ii = 0; ii < length; ii++)
                {
                    int modul = process % 10;

                    if ((ii + 1) % 2 == 0)
                    {
                        evenSum += modul;
                    }
                    else
                    {
                        oddSum += modul;
                    }

                    process = (process - modul) / 10;
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
