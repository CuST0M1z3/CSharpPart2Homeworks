using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AddsIntegers
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
      
        if (firstNumber.Length == secondNumber.Length)
        {
            int[] firstAsDigits = new int[firstNumber.Length];
            int[] secondAsDigits = new int[secondNumber.Length];

            int lengthOne = firstNumber.Length - 1;
            int lengthTwo = secondNumber.Length - 1;

            for (int i = 0; i < firstAsDigits.Length; i++)
            {
                firstAsDigits[i] = firstNumber[lengthOne] - '0';
                lengthOne--;
            }

            for (int i = 0; i < secondAsDigits.Length; i++)
            {
                secondAsDigits[i] = secondNumber[lengthTwo] - '0';
                lengthTwo--;
            }

            SumOfDigits(firstAsDigits, secondAsDigits);
        }
        else if (firstNumber.Length > secondNumber.Length)
        {
            int[] firstAsDigits = new int[firstNumber.Length];
            int[] secondAsDigits = new int[firstNumber.Length];

            int lengthOne = firstNumber.Length - 1;
            int lengthTwo = secondNumber.Length - 1;

            for (int i = 0; i < firstAsDigits.Length; i++)
            {
                firstAsDigits[i] = firstNumber[lengthOne] - '0';
                lengthOne--;
            }

            for (int i = 0; i < firstAsDigits.Length; i++)
            {
                if (i < secondNumber.Length)
                {
                    secondAsDigits[i] = secondNumber[lengthTwo] - '0';
                    lengthTwo--;
                }
                else
                {
                    secondAsDigits[i] = 0;
                }
            }

            SumOfDigits(firstAsDigits, secondAsDigits);

        }

        else if (firstNumber.Length < secondNumber.Length)
        {
            int[] firstAsDigits = new int[secondNumber.Length];
            int[] secondAsDigits = new int[secondNumber.Length];

            int lengthOne = firstNumber.Length - 1;
            int lengthTwo = secondNumber.Length - 1;
            for (int i = 0; i < secondAsDigits.Length; i++)
            {
                if (i < firstNumber.Length)
                {
                    firstAsDigits[i] = firstNumber[lengthOne] - '0';
                    lengthOne--;
                }
                else
                {
                    firstAsDigits[i] = 0;
                }               
            }

            for (int i = 0; i < secondAsDigits.Length; i++)
            {
                secondAsDigits[i] = secondNumber[lengthTwo] - '0';
                lengthTwo--;
            }

            SumOfDigits(firstAsDigits, secondAsDigits);

        }
    }

    static void SumOfDigits(int[] firstDigits, int[] secondDigits)
    {
        string sumIs = "";
        int sum = 0;
        int nextSum = 0;

        for (int i = 0; i < firstDigits.Length; i++)
        {
            sum = firstDigits[i] + secondDigits[i] + nextSum;
            nextSum = 0;
            if (sum > 9 && i != firstDigits.Length - 1)
            {
                nextSum = sum / 10;
                sum = sum % 10;
                sumIs = sum.ToString() + sumIs;
            }
            else
            {
                sumIs = sum.ToString() + sumIs;
            }
        }

        Console.WriteLine("Sum is: " + sumIs);
    }
}

