using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MostFrequentNumber
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

        int count = 1;
        int maxSequence = 0;
        int number = 0;


        for (int i = 0; i < n; i++)
        {
            number = arr[i];
            count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (number == arr[j])
                {
                    count++;
                }
                if (count > maxSequence)
                {
                    maxSequence = count;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            number = arr[i];
            count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (number == arr[j])
                {
                    count++;
                }                
            }
            if (count == maxSequence)
            {
                m.Add(number);
            }
        }

        foreach (var num in m)
        {
            Console.Write("The most frequent number is " + num + "({0} times)" , maxSequence);
            Console.WriteLine();
        }

    }
}

