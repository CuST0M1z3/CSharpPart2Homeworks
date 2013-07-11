using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CombinationsOfKElements
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[k];

        CombinationsOfK(array, 0, 1, n);
    }

    private static void CombinationsOfK(int[] array, int k, int start, int n)
    {
        if (k == array.Length)
        {
            PrintResult(array);
        }
        else
        {
            for (int i = start; i <= n; i++)
            {
                array[k] = i;
                CombinationsOfK(array, k + 1, i + 1, n);
            }
        }
    }

    private static void PrintResult(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

