using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that extracts from a given text all sentences containing given word.
 */

class ContainWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] listOfSentences = text.Split('.');
        string word = "in";

        for (int i = 0; i < listOfSentences.Length; i++)
        {                        
            if (Regex.IsMatch(listOfSentences[i], @"\b" + word + @"\b"))
            {
                Console.WriteLine(listOfSentences[i].Trim());
            }
        }
    }
}

