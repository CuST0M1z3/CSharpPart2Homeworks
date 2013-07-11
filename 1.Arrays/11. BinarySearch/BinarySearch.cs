using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        int startIndex = 0;
        int endIndex = n;
        int middleElement = 0;
        int xPosition = 0;
        bool xFound = false;

        while (xFound == false)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                middleElement = arr[(startIndex + endIndex) / 2];
                if (middleElement == x)
                {
                    xFound = true;
                    xPosition = (startIndex + endIndex) / 2;
                    break;
                }
                else if (x < middleElement)
                {
                    startIndex = 0;
                    endIndex = endIndex / 2;
                    break;
                }
                else if (x > middleElement)
                {
                    startIndex = (endIndex / 2) + 1;
                    break;
                }
            }
        }

        if (xFound == false)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            Console.WriteLine("X is founded at position arr[{0}]", xPosition);
        }
    }
}

