using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxElementInArray
{
    static void Main()
    {
        int[] array = { 1, 7, 6, 4, 2, 8, 1, 3, 3, 6, 5, 3 };

        int startIndex = int.Parse(Console.ReadLine());

        MaxElementInAPortion(array, startIndex);
        SortedDescendingArray(array);
        SortedAscendingArray(array);
    }

    static void MaxElementInAPortion(int[] array, int startIndex)
    {
        if (startIndex >= array.Length || startIndex < 0)
        {
            Console.WriteLine("Index is out of array range");
            return;
        }
        int maxElement = int.MinValue;
        int element = 0;
        int elementPosition = 0;
        for (int i = startIndex; i < array.Length; i++)
        {
            element = array[i];
            if (element > maxElement)
            {
                maxElement = element;
                elementPosition = i;
            }
        }

        Console.WriteLine("Max element is at index {0} and is equal to: {1}", elementPosition, maxElement);

    }

    static void SortedDescendingArray(int[] array)
    {
        array = array.OrderByDescending(c => c).ToArray();

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void SortedAscendingArray(int[] array)
    {

        Array.Sort(array);

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

}

