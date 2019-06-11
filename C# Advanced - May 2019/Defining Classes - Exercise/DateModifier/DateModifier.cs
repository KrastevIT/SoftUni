using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static void DatesDifference(int[] firstDates, int[] secondDates)
        {
            int firstAge = firstDates[0];
            int firstMonth = firstDates[1];
            int firstDate = firstDates[2];

            int secondAge = secondDates[0];
            int secondMonth = secondDates[1];
            int secondDate = secondDates[2];

            DateTime d1 = new DateTime(firstAge, firstMonth, firstDate);
            DateTime d2 = new DateTime(secondAge, secondMonth, secondDate);

            double totalDays = (d1 - d2).TotalDays;

            Console.WriteLine(Math.Abs(totalDays));

        }



    }
}
