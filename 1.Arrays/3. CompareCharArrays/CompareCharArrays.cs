using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareCharArrays
{
    static void Main()
    {
        char[] arr1 = { 'a', 'c', 'f', 'k' };
        char[] arr2 = { 'b', 'c', 'e', 'k' };

        int lenght1 = arr1.Length;
        int lenght2 = arr2.Length;

        if (lenght1 == lenght2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }  
    }
}

