using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Enter number to reverse: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.Write("Reversed digit is : ");
        Console.WriteLine(ReverseDigit(number));

        int[] array = { 1, 6, 3, 2, 8, -3, 6, 2 };

        Console.Write("Average of a sequence is: ");
        Console.WriteLine(Average(array));

        Console.Write("Enter a for linear equation: ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("Enter b for linear equation: ");
        decimal b = decimal.Parse(Console.ReadLine());

        SolveLinearEquation(a, b);
    }

    static decimal Average(int[] array)
    {
        int currentSum = 0;
        decimal avgSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
        }

        avgSum = ((decimal)currentSum / array.Length);

        return avgSum;
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

    static void SolveLinearEquation(decimal a, decimal c)
    {
        decimal result = 0;

        if (a == 0)
        {
            Console.WriteLine("a should not be equal to 0");
        }
        else
        {
            result = -c / a;
            Console.WriteLine("The result is: " + result);
        }
    }
}

