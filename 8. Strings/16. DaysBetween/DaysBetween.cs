using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. */

class DaysBetween
{
    static void Main()
    {
        DateTime firstDate = new DateTime(2006, 02, 27);
        DateTime secondDate = new DateTime(2004, 03, 3);
        string format = "d.MM.yyyy";
        string daysFormat = "dd";

        TimeSpan distance = firstDate - secondDate;

        Console.WriteLine("Distance between {0} and {1} is: {2}", firstDate.ToString(format, CultureInfo.InvariantCulture),
            secondDate.ToString(format, CultureInfo.InvariantCulture), distance.ToString(daysFormat, CultureInfo.InvariantCulture));

    }
}

