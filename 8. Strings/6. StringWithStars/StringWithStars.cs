using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
 * Print the result string into the console.
 */ 

class StringWithStars
{
    static void Main()
    {
        Console.Write("Enter string with length <= 20: ");
        string word = Console.ReadLine();

        if (word.Length < 20)
        {
            word = word.PadRight(20, '*');            
        }
        Console.WriteLine(word);
    }
}

