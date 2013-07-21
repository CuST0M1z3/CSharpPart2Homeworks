using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

class Palindromes
{
    static void Main()
    {
        string text = "Telerik academy is ABBA, school is lamal, and you are exe";

        char[] separators = new char[] { ' ' , ','};
        string[] splittedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        List<string> palindromes = new List<string>();

        for (int i = 0; i < splittedText.Length; i++)
        {
            bool isPalindrome = true;
            char[] symbols = splittedText[i].ToCharArray();
            for (int k = 0; k < symbols.Length / 2; k++)
            {
                if (symbols[k] != symbols[symbols.Length - 1 - k])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                palindromes.Add(splittedText[i]);
            }
        }

        foreach (var item in palindromes)
        {
            Console.WriteLine(item);
        }
    }
}

