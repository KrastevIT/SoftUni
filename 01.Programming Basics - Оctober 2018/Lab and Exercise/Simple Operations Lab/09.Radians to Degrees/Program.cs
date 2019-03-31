using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var degree = rad * 57.29578;
            var resultDegree = Math.Round(degree, 2);
            var resultABS = Math.Abs(resultDegree);
            Console.WriteLine(resultABS);
        }
    }
}