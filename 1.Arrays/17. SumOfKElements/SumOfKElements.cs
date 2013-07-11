using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class SumOfKElements
{
    static void Main()
    {
        BigInteger s = BigInteger.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] a = new long[n];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = long.Parse(Console.ReadLine());
        }

        int maxI = 1;

        for (int i = 1; i <= n; i++)
        {
            maxI *= 2;
        }

        maxI -= 1;
        int count = 0;
        int kCount = 0;
        for (int i = 1; i <= maxI; i++)
        {
            BigInteger currentSum = 0;
            kCount = 0;
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;

                if (bit == 1)
                {
                    kCount++;
                    if (kCount <= 3)
                    {                        
                        currentSum += a[j];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (currentSum == s && kCount == k)
            {
                count++;
            }
        }
        if (count >= 1)
        {
            Console.WriteLine("Yes " + count + " times");
        }
    }
}

