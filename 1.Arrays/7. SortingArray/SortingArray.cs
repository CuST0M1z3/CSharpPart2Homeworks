using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        /* List<int> sortList = new List<int>();

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<int> arrList = arr.ToList();

        while (arrList.Count > 0)
        {
            int min = arrList[0];
            for (int j = 0; j < arrList.Count; j++)
            {
                if (arrList[j] <= min)
                {
                    min = arrList[j];
                }
            }
            sortList.Add(min);
            arrList.Remove(min);          
        }
             
        Console.WriteLine();
        foreach (var num in sortList)
        {
            Console.Write(num + " ");
        } */

        
        int minValue = 0;
        int index = 0;

        for (int i = 0; i < (n - 1); i++)
        {
            int currentValue = arr[i];
            index = i;
            for (int j = (i + 1); j < n; j++)
            {
                if (arr[j] < currentValue)
                {
                    minValue = arr[j];
                    index = j;
                }           
            }
            if (index != i)
            {
                arr[index] = currentValue;
                arr[i] = minValue;
            }
        }

        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }

    }
}

