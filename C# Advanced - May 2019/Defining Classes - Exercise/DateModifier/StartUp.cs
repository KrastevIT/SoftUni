using System;
using System.Linq;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            DateModifier.DatesDifference(firstInput, secondInput);

        }
    }
}
