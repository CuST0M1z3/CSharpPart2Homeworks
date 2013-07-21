using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a string 
 * from the console and prints all different letters in the string along 
 * with information how many times each letter is found. */

class CheckLetters
{
    static void Main()
    {
        string text = "Telerik academy is the best, school is better, and you are beautiful";

        bool[] visited = new bool[text.Length];


        for (int i = 0; i < text.Length; i++)
        {
            int count = 0;
            if (visited[i] == false && char.IsLetter(text[i]))
            {
                int index = text.IndexOf(text[i], 0);
                while (index != -1)
                {
                    visited[index] = true;
                    index = text.IndexOf(text[i], index + 1);
                    count++;
                }
                Console.WriteLine("{0} - {1} times", text[i], count);
            }                    
        }
    }
}

