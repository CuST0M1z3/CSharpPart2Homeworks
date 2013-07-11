using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargestNumberInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        Random rand = new Random();

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
        }

        Array.Sort(array);

        int largestNumberIndex = Array.BinarySearch(array, k);

        if (largestNumberIndex < 0)
        {
            int result = array[~largestNumberIndex - 1];
            Console.WriteLine(array[~largestNumberIndex - 1]);
        }
        else if (largestNumberIndex == 0)
        {
            Console.WriteLine(array[largestNumberIndex]);
        }
        else
        {
            Console.WriteLine(array[largestNumberIndex - 1]);
        }
    }

}

