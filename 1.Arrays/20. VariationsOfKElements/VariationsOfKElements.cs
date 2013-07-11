using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VariationsOfKElements
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[k];

        VariationsOfK(array, 0, n);            

    }

    private static void VariationsOfK(int[] array, int k, int n)
    {
        if (k == array.Length)          
        {
            PrintResult(array);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[k] = i;
                VariationsOfK(array, k + 1, n);     
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

