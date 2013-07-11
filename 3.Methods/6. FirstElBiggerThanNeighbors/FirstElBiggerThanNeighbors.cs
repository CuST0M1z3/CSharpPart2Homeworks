using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstElBiggerThanNeighbors
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} element of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        BiggerToNeighbors(array);

    }

    static void BiggerToNeighbors(int[] array)
    {
        bool numberFound = false;
        for (int i = 1; i < array.Length - 1; i++)
        {
            int number = array[i];
            if ((number > array[i - 1]) && (number > array[i + 1]))
            {
                Console.WriteLine("Index of the first element in array that is bigger than its neighbors is: " + i);
                numberFound = true;
                break;
            }                   
        }
        if (numberFound == false)
        {
            Console.WriteLine(-1);
        }
    }
}

