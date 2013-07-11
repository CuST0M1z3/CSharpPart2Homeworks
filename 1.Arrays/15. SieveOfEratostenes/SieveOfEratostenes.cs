using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SieveOfEratostenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        List<bool> notAPrime = new List<bool>();

        for (int i = 2; i <= n; i++)
        {
            notAPrime.Add(true);
        }

        for (int i = 2; i <= n; i++)
        {
            numbers.Add(i);
        }

        int p = numbers[0];

        PrimeNumbers(numbers, notAPrime, p);
        Print(numbers, notAPrime);
    }

    static void PrimeNumbers(List<int> numbers, List<bool> notAPrime, int p)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (notAPrime[i] == true)
            {
                p = numbers[i];
                for (int j = p + i; j < numbers.Count; j += p)
                {
                    notAPrime[j] = false;
                }
            }
        }
    }

    static void Print(List<int> numbers, List<bool> notAPrime)
    {
        Console.Write("Prime numbers are: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            if (notAPrime[i] == true)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

