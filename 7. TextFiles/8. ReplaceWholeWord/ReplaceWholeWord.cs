using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Modify the solution of the previous problem to replace only whole words (not substrings).
 */

class ReplaceWholeWord
{
    static void Main()
    {
        ReplaceWord();
    }
    static void ReplaceWord()
    {
        using (StreamWriter outputFile = new StreamWriter(@"..\..\outputfile.txt")) // check your .cs directory
        {
            using (StreamReader inputFile = new StreamReader(@"..\..\inputfile.txt")) 
            {
                string line = inputFile.ReadLine();
                while (line != null)
                {
                    outputFile.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = inputFile.ReadLine();
                }
            }
        }
        Console.WriteLine("New file is created");
        return;
    }
}

