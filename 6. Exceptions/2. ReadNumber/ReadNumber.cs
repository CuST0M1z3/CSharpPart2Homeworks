using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, the method should throw an exception. 
 * Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

class ReadNumber
{
    static void Main()
    {

        Console.Write("Enter start of range: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end of range: ");
        int end = int.Parse(Console.ReadLine());
        ReadNumbers(start, end);

    }

    static void ReadNumbers(int start, int end)
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number {0}: ", i);
                int number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                Console.WriteLine(number);
            }
        }
        catch (ArgumentNullException)
        {
            throw;
        }
        catch (FormatException)
        {
            throw;
        }
        catch (OverflowException)
        {
            throw;
        }
        catch (ArgumentOutOfRangeException)
        {
            throw;
        }
    }
}

