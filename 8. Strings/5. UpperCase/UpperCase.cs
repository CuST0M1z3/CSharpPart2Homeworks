using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.  */

class UpperCase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string openTag = "<upcase>";
        string closedTag = "</upcase>";

        while (text.IndexOf(openTag) != -1)
        {
            int startIndex = text.IndexOf(openTag);
            int lastIndex = text.IndexOf(closedTag);
            string upperText = text.Substring(startIndex + openTag.Length, lastIndex - startIndex - openTag.Length);
            text = text.Replace(openTag + upperText + closedTag, upperText.ToUpper());
        }
        Console.WriteLine(text);
    }
}

