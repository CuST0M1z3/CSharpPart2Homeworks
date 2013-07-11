using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VariableArguments
{
    static void Main()
    {
        Console.Write("Sum is: ");
        Console.WriteLine(CalcSum(2, 7, 8, 3));
        Console.Write("Min elements is: ");
        Console.WriteLine(MinElement(2, 7, 8, 3));
        Console.Write("Max element is: ");
        Console.WriteLine(MaxElement(2, 7, 8, 3));
        Console.Write("Product is: ");
        Console.WriteLine(ProductOfElements(2, 7, 8, 3));
    }

    static long MinElement(params int[] elements)
    {
        long min = long.MaxValue;

        foreach (var num in elements)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }

    static long MaxElement(params int[] elements)
    {
        long max = long.MinValue;

        foreach (var num in elements)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (var num in elements)
        {
            sum += num;
        }
        return sum;
    }

    static long ProductOfElements(params int[] elements)
    {
        long product = 1;
        foreach (var num in elements)
        {
            product *= num;
        }
        return product;
    }

}

