using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
 * Ensure it will work with large files (e.g. 100 MB).
 */

class ReplaceSubstring
{
    static void Main()
    {
        ReplaceOccurencesOfSubString();
    }
    static void ReplaceOccurencesOfSubString()
    {
        using (StreamWriter outputFile = new StreamWriter(@"..\..\outputfile.txt")) // check your .cs directory
        {
            using (StreamReader inputFile = new StreamReader(@"..\..\inputfile.txt"))
            {
                string line = inputFile.ReadLine();
                while (line != null)
                {
                    outputFile.WriteLine(line.Replace("start", "finish"));
                    line = inputFile.ReadLine();
                }
            }     
        }
        Console.WriteLine("New file is created");
        return;          
    }
}

