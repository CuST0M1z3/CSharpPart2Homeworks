using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        BigInteger[] array = new BigInteger[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        FactorialMethod(array);
    }

    static void FactorialMethod(BigInteger[] array)
    {
        BigInteger[] factorial = new BigInteger[100];

        factorial[0] = 1;
        Console.WriteLine(factorial[0]);

        for (int i = 1; i < factorial.Length; i++)
        {
            factorial[i] = array[i] * factorial[i - 1];
            Console.WriteLine(factorial[i]);
        }
    }
}

