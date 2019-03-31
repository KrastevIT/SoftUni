using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            int sum1 = 0;
            int sum2 = 0;
            for (int i = int.Parse(number1); i <= int.Parse(number2); i++)
            {
                number1 = i.ToString();
                sum1 = (int)Char.GetNumericValue(number1[0]) + (int)Char.GetNumericValue(number1[1]);
                sum2 = (int)Char.GetNumericValue(number1[3]) + (int)Char.GetNumericValue(number1[4]);
                if (sum1 != sum2)
                {
                    if (sum1 > sum2)
                    {
                        sum2 += (int)Char.GetNumericValue(number1[2]);
                    }
                    else
                    {
                        sum1 += (int)Char.GetNumericValue(number1[2]);
                    }
                }

                if (sum1 == sum2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
