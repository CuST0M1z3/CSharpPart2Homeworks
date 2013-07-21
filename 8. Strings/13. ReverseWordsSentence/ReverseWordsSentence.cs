using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
 */

class ReverseWordsSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        char[] separators = new char[] { ' ', ',', '!' };
        string[] splittedText = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);

        Stack<string> stack = new Stack<string>();

        string reversedText = String.Empty;

        for (int i = 0; i < splittedText.Length; i++)
        {
            stack.Push(splittedText[i]);
        }

        foreach (var item in stack)
        {
            reversedText += item + " ";
        }
        Console.WriteLine(reversedText);
    }
}

