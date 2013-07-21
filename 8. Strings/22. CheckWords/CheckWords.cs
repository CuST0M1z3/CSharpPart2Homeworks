using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a string from the console and lists all different words 
 * in the string along with information how many times each word is found.
 */

class CheckWords
{
    static void Main()
    {
        string text = "Telerik academy is the best, Telerik is the best, and you are the best beautiful";

        char[] separators = new char[] {' ', ','};

        string[] splittedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        bool[] visited = new bool[splittedText.Length];

        for (int i = 0; i < splittedText.Length; i++)
        {
            int count = 0;
            if (visited[i] == false)
            {
                string searchedWord = splittedText[i];
                for (int j = i; j < splittedText.Length; j++)
                {
                    if (splittedText[i] == splittedText[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }
                visited[i] = true;
                Console.WriteLine(splittedText[i] + " " + count);
            }                               
        }
    }
}

