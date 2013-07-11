using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSort
{
    static void Main()
    {
        int[] array = { 8, 3, 6, 2, 4, 8, 10, 2 };

        int rightIndex = array.Length - 1;

        Console.WriteLine("Unsorted array is: ");
        Print(array);

        QuickSortMethod(array, 0, rightIndex);

        Console.WriteLine("Sorted array is: ");
        Print(array);
    }

    static int PivotIndex(int[] array, int left, int right, int pivotIndex)
    {
        int pivotValue = array[pivotIndex];
        Swap(ref array[pivotIndex], ref array[right]);
        int storeIndex = left;

        for (int i = left; i < right; i++)
        {
            if (array[i] <= pivotValue)
            {
                Swap(ref array[i], ref array[storeIndex]);
                storeIndex += 1;
            }
        }
        Swap(ref array[storeIndex], ref array[right]);
        return storeIndex;
    }

    static void QuickSortMethod(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = left + (right - left) / 2;
            int pivotNewIndex = PivotIndex(array, left, right, pivotIndex);

            QuickSortMethod(array, left, pivotNewIndex - 1);

            QuickSortMethod(array, pivotNewIndex + 1, right);
        }
    }

    static void Print(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static void Swap(ref int first, ref int second)
    {
        int oldFirst = first;
        first = second;
        second = oldFirst;
    }
}

