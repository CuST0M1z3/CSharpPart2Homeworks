using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

class ExtractEmailAdress
{
    static void Main()
    {
        string text = "Contact Telerik at telerik@telerik.com or nakov@gmail.com";

        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}

