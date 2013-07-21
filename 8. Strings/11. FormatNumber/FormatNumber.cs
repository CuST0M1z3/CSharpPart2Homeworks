using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols.
 */

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal : {0,15:D}", number);
        Console.WriteLine("Hex : {0,15:X}", number);
        Console.WriteLine("Percentage : {0,15:P}", number);
        Console.WriteLine("Scientific : {0,15:E}", number);
    }
}

