using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.
 */

class IntegerNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        try
        {
            int num = int.Parse(number);
            if (num <= 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            Console.Write("Square root of number is: ");
            Console.WriteLine(Math.Sqrt(num));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }  
    }
}

