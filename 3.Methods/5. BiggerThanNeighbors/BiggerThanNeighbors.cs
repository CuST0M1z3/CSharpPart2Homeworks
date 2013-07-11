using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggerThanNeighbors
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} element of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        BiggerToNeighbors(array, position);

    }

    static void BiggerToNeighbors(int[] array, int pos)
    {
        int number = array[pos];

        if ((pos > 0) && (pos < array.Length - 1))
        {
            if ((array[pos - 1] < array[pos]) && (array[pos + 1] < array[pos]))
            {
                Console.WriteLine("Number at position {0} is bigger than its neighbors", pos);
            }
            else
            {
                Console.WriteLine("Number at position {0} is not bigger than its neighbors", pos);
            }
        }
        else
        {
            Console.WriteLine("Number at position {0} not have two neighbors", pos);
        }
    }
}

