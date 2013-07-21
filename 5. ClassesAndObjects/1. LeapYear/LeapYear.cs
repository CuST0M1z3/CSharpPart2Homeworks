using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
 */

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is leap year", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year", year);
        }
    }
}

