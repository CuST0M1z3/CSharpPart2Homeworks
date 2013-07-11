using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter Lenght of Arrays: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter arr1 element {0}: ", i);
            arr1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter arr2 element {0}: ", i);
            arr2[i] = int.Parse(Console.ReadLine());

            if (arr1[i] == arr2[i])
            {
                Console.WriteLine("Element {0} of arr1 is equal to element {0} of arr2: ", i);
            }
            else
            {
                Console.WriteLine("Element {0} of arr1 is not equal to element {0} of arr2: ", i);
            }
        }
    }
}

