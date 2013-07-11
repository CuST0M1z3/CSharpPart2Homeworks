using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubsetSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());

        List<int> m = new List<int>();

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int count = 0;
        int len = 0;

        for (int i = 0; i < n; i++)
        {
            currentSum = 0;
            count = 0;
            for (int j = i; j < n; j++)
            {
                currentSum += arr[j];
                count++;
                if (currentSum == s)
                {
                    len = count;
                    count = 0;
                    for (int k = (len - 1); k >= 0; k--)
                    {
                        m.Add(arr[j - k]);
                    }                    
                }
            }          
        }

        foreach (var num in m)
        {
            Console.Write(num + " ");
        }

    }
}

