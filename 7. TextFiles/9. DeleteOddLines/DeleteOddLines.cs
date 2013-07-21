using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that deletes from given text file all odd lines. The result should be in the same file.
 */

class DeleteOddLines
{
    static void Main()
    {       
        OddLinesDelete();
    }

    static void OddLinesDelete()
    {
        List<string> linesToDelete = new List<string>();

        using (StreamReader readFile = new StreamReader(@"..\..\test.txt"))
        {
            int lineNumber = 0;
            string line = readFile.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                if (lineNumber % 2 == 0)
                {
                    linesToDelete.Add(line);
                }
                lineNumber++;
                line = readFile.ReadLine();
            }
        }
        Console.WriteLine();
        using (StreamWriter writeFile = new StreamWriter(@"..\..\test.txt"))
        {
            foreach (var item in linesToDelete)
            {
                writeFile.WriteLine(item);
                Console.WriteLine(item);
            }
        }
        Console.WriteLine();
        Console.WriteLine("File is updated! Check your .cs directory");
        return;      
    }
}

