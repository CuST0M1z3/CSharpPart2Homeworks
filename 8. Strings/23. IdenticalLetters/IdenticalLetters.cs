using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
 */

class IdenticalLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder newText = new StringBuilder();

        char currentLetter;
        char lastLetter = ' ';

        for (int i = 0; i < text.Length; i++)
        {
            currentLetter = text[i];
            if (currentLetter != lastLetter)
            {
                if (char.IsLetter(lastLetter))
                {
                    newText.Append(lastLetter);
                }
            }
            lastLetter = currentLetter;
        }
        if (char.IsLetter(lastLetter))
        {
            newText.Append(lastLetter);
        }
        Console.WriteLine(newText.ToString());
    }
}

