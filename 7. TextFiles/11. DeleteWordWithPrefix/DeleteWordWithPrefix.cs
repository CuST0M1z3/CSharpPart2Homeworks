using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that deletes from a text file all words that start with the prefix "test". 
 * Words contain only the symbols 0...9, a...z, A…Z, _.
 */

class DeleteWordWithPrefix
{
    static void Main()
    {
        DeleteSelectedWords();
    }

    static void DeleteSelectedWords()
    {
        using (StreamReader inputFile = new StreamReader(@"..\..\test.txt"))
        {
            string line = inputFile.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);               
                Console.WriteLine(Regex.Replace(line, @" test\w+", ""));
                Console.WriteLine();
                line = inputFile.ReadLine();
            }
        }
        return;
    }
}

