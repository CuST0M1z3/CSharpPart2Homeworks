using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfStrings
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] matrix = new string[n];

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine();
        }
        
        foreach (string s in SortByLength(matrix))
        {
            Console.WriteLine(s);
        }
    }

    static IEnumerable<string> SortByLength(IEnumerable<string> e)
    {
        var sorted  = from s in e
            orderby s.Length ascending
            select s;
        return sorted;
    }
}

