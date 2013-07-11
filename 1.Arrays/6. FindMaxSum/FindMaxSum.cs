using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FindMaxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            sum = 0;
            if (i + k > n)
            {
                break;
            }
            for (int j = i; j < i + k; j++)
            {
                sum += arr[j];
            }

            if (sum > maxSum)
            {
                maxSum = sum;
            }     
        }
        if (maxSum == int.MinValue)
        {
            Console.WriteLine("k > n");
        }
        else
        {
            Console.WriteLine("Maximum sum of {0} elements is: {1}", k, maxSum);
        }      
    }
}

