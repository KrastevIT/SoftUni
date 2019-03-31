using System;
using System.Collections.Generic;

namespace _05_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //string[] num0 = { " " };
            string[] num2 = { "a", "b", "c" };
            string[] num3 = { "d", "e", "f" };
            string[] num4 = { "g", "h", "i" };
            string[] num5 = { "j", "k", "l" };
            string[] num6 = { "m", "n", "o" };
            string[] num7 = { "p", "q", "r", "s" };
            string[] num8 = { "t", "u", "v" };
            string[] num9 = { "w", "x", "y", "z" };

            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string inputNumber = Console.ReadLine();

                if (inputNumber[0] == 48) //0
                {
                    words.Add(" ");
                }
                else if (inputNumber[0] == 50) //2
                {
                    words.Add(num2[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 51) // 3
                {
                    words.Add(num3[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 52) // 4
                {
                    words.Add(num4[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 53) //5
                {
                    words.Add(num5[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 54) // 6
                {
                    words.Add(num6[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 55) //7
                {
                    words.Add(num7[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 56) //8
                {
                    words.Add(num8[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 57) // 9
                {
                    words.Add(num9[inputNumber.Length - 1]);
                }
                else if (inputNumber[0] == 49) // 1
                {
                    break;
                }


            }

            Console.WriteLine(String.Join("",words));
        }
    }
}
