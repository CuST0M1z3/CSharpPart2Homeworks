using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample"  "elpmas". */

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();

        StringBuilder reversedString = new StringBuilder();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedString.Append(word[i]);
        }

        Console.WriteLine(reversedString.ToString());
    }
}

