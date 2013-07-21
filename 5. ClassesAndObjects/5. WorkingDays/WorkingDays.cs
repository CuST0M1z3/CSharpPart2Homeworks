using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

class WorkingDays
{
    static void Main()
    {
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        DateTime now = DateTime.Today;
        DateTime currentDate = now;
        DateTime givenDate = new DateTime(year, month, day);
        int workingDays = 0;
        string format = "d.M.yyyy";
        bool holidayFound = false;

        if (now > givenDate)
        {
            Console.WriteLine("You have enter a invalid date");
            return;
        }

        DateTime[] holidays =
        {
            new DateTime(2014, 1, 1),
            new DateTime(2014, 2, 2),
            new DateTime(2014, 1, 3),
            new DateTime(2014, 4, 25),
            new DateTime(2014, 9, 6)
        };

        int time = (givenDate - currentDate).Days;

        for (int i = 0; i <= time; i++)
        {
            for (int j = 0; j < holidays.Length; j++)
            {
                if (currentDate == holidays[j])
                {
                    holidayFound = true;
                }
            }
            if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday || holidayFound == true)
            {
                currentDate = currentDate.AddDays(1);
            }
            else
            {
                workingDays++;
                currentDate = currentDate.AddDays(1);
            }
            holidayFound = false;
        }
        Console.WriteLine("Working days between {0} and {1} are {2} ", now.ToString(format), givenDate.ToString(format), workingDays);
    }
}

