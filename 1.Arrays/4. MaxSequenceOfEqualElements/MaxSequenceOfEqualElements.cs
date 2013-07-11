using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] arr = { 2, 2, 1, 1, 2, 3, 3, 3, 2, 2, 2, 4, 4, 4 };

        List<int> m = new List<int>();

        int len = 1;
        int maxLen = 0;
        int longestNumber = 0;
        int length = arr.Length;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
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

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i+1])
            {
                len++;
                if (len == maxLen)
                {
                    longestNumber = arr[i];
                    m.Add(longestNumber);
                }    
            }
            else
            {              
                len = 1;
            }            
        }

        foreach (var num in m)
        {
            for (int i = 0; i < maxLen; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}

