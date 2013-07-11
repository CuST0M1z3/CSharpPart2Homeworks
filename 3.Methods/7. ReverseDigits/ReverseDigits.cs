using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseDigits
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine(ReverseDigit(number));
    }

    static decimal ReverseDigit(decimal number)
    {

        string stringNumber = number.ToString();
        string newNumber = "";
        for (int i = stringNumber.Length - 1; i >= 0; i--)
        {
            newNumber += stringNumber[i];
            stringNumber = stringNumber.Remove(i);
        }

        decimal finalNumber = Convert.ToDecimal(newNumber);

        return finalNumber;
    }
}

