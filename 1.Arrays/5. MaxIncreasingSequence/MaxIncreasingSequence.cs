using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxIncreasingSequence
{
    static void Main()
    {
        int[] arr = { 3, 4, 5, 7, 2, 3, 4, 2, 4, 5, 6 };

        List<int> m = new List<int>();

        int len = 1;
        int maxLen = 0;
        int longestNumber = 0;
        int length = arr.Length;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                len++;
                if (len > maxLen)
                {
                    maxLen = len;
                }
            }
            else
            {
                len = 1;
            }
        }

        len = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                len++;
                if (len == maxLen)
                {
                    longestNumber = arr[i];
                    for (int j = (maxLen - 1); j >= 0; j--)
                    {
                        m.Add(arr[i - j]);
                    }                    
                }
            }
            else
            {                
                len = 1;
            }
        }

        foreach (var num in m)
        {
            Console.Write(num + " ");
        }
    }
}

