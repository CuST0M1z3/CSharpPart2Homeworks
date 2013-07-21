using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* You are given a sequence of positive integer values written into a string, separated by spaces. 
 * Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461
 */

class SumFromString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string numberSequence = Console.ReadLine();

        Console.Write("Sum is: ");
        Console.WriteLine(SumOfNumbers(numberSequence));
    }

    static int SumOfNumbers(string number)
    {
        List<string> numbers = new List<string>();
        string num = "";
        int sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] >= '0' && number[i] <= '9')
            {
                num += number[i];
                if (i == number.Length - 1)
                {
                    numbers.Add(num);
                }
            }
            else if ((number[i] == ' ' && num != "") || ((i == number.Length - 1) && num != "") || (char.IsLetter(number[i]) && num != ""))
            {
                numbers.Add(num);
                num = "";
            }
        }

        foreach (var item in numbers)
        {
            int sNum = int.Parse(item);
            sum += sNum;
        }

        return sum;
    }
}

