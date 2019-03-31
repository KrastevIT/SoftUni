using System;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool check = false;
            int temp = 0;
            //
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                temp = i;
                while (temp != 0)
                {
                    sum += (temp % 10);
                    temp /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                sum = 0;

                Console.WriteLine($"{i} -> {check}");
            }
        }
    }
}
