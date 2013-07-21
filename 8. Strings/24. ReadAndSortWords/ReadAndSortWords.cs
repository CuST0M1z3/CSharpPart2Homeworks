using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */

class ReadAndSortWords
{
    static void Main()
    {
        string words = "Telerik academy GitHub Windows Linux Samsung";

        char[] separators = new char[] { ' ' };

        string[] splittedWords = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(splittedWords);

        for (int i = 0; i < splittedWords.Length; i++)
        {
            Console.WriteLine(splittedWords[i]);
        }
    }
}

