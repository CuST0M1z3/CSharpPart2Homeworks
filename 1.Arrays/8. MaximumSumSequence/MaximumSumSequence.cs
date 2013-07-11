using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximumSumSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        List<int> m = new List<int>();

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        int currentSum = 0;
        int len = 0;
        int maxLen = 0;

        for (int i = 0; i < n; i++)
        {
            currentSum = 0;
            len = 0;
            for (int j = i; j < n; j++)
            {
                currentSum += arr[j];
                len++;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxLen = len;
                }
            }         
        }

        len = 0;

        for (int i = 0; i < n; i++)
        {
            currentSum = 0;
            len = 0;
            for (int j = i; j < n; j++)
            {
                currentSum += arr[j];
                len++;
                if (currentSum == maxSum)
                {
                    for (int k = 0; k < maxLen; k++)
                    {
                        if ((i + k) <= maxLen)
                        {
                            m.Add(arr[i + k]);
                        }                       
                    }
                }
            }           
        }

        Console.Write("{ ");
        foreach (var num in m)
        {
            Console.Write(num + " ");
        }
        Console.Write("}");
    }
}

