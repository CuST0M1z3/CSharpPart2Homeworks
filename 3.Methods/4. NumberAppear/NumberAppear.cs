using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberAppear
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} element of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        NumberAppearing(array, number);

    }

    static void NumberAppearing(int[] array, int searchNumber)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchNumber)
            {
                count++;
            }
        }

        Console.WriteLine("Searching number is {0} and appears: {1} times", searchNumber, count);
    }
}

