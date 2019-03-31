using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            string stop = string.Empty;

            int prime_sum = 0;

            int nonprime_sum = 0;

            while (stop != "stop")
            {
                stop = Console.ReadLine();

                int theNum;
                bool parsed = Int32.TryParse(stop, out theNum);

                if (parsed)
                {
                    if (theNum < 3)  
                    {
                        if (theNum == 2)
                        {

                            prime_sum = prime_sum + theNum;
                        }
                        else
                        {
                            if (theNum < 0)
                            {
                                Console.WriteLine("Number is negative.");
                            }
                            else if (theNum == 1)
                            {
                                nonprime_sum = nonprime_sum + theNum;
                            }

                        }
                    }
                    else
                    {
                        if (theNum % 2 == 0)
                        {
                            nonprime_sum = nonprime_sum + theNum;
                        }
                        else
                        {
                            int div;

                            for (div = 3; theNum % div != 0; div += 2)
                                ;  

                            if (div == theNum)
                            {

                                prime_sum = prime_sum + theNum;
                            }
                            else
                            {

                                nonprime_sum = nonprime_sum + theNum;
                            }
                        }
                    }
                }
                else if (stop == "stop")
                {
                    break;
                }
            }
            Console.WriteLine("Sum of all prime numbers is: {0}", prime_sum);
            Console.WriteLine("Sum of all non prime numbers is: {0}", nonprime_sum);
        }
    }
}