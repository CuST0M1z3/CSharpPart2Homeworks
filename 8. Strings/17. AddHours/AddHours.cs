using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
 * prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

class AddHours
{
    static void Main()
    {
        CultureInfo culture = new CultureInfo("bg-BG");
        DateTime now = DateTime.Now;
        string format = "d.MM.yyyy HH:mm:ss";

        Console.WriteLine(now.ToString(format));

        now = now.AddHours(6);
        now = now.AddMinutes(30);

        Console.WriteLine("After 6 hours and 30 minutes is: " + now.ToString(format) + " " + now.ToString("dddd", culture));
    }
}
