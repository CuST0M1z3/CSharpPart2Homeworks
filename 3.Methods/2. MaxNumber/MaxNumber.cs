using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Max number is: " + GetMax(GetMax(a, b), c)); 

    }

    static int GetMax(int a, int b)
    {
        int max = int.MinValue;
        if (a > b)
        {
            max = a;
        }
        else if (a < b)
        {
            max = b;
        }
        else if (a == b)
        {
            max = a;
        }
        return max;
    }
}

