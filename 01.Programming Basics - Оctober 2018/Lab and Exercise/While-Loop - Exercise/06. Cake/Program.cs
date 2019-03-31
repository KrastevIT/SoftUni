using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var sum = n1 * n2;

            while (sum >= 0)
            {
                var n3 = Console.ReadLine().ToLower();
                if (n3 == "stop")
                {
                    break;
                }
                sum -= int.Parse(n3);

            }
            if (sum >= 0)
            {
                Console.WriteLine("{0} pieces are left.", sum);
            }
            else
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", sum * -1);
            }
        }
    }
}
