using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file.
 */

class InsertLines
{
    static void Main()
    {
        StreamReader readFile = new StreamReader(@"..\..\test.txt");
        PrintLinesWithIndex(readFile);
    }

    static void PrintLinesWithIndex(StreamReader file)
    {
        StreamWriter writeFile = new StreamWriter(@"..\..\final.txt"); // check .cs directory
        using (writeFile)
        {
            using (file)
            {
                int lineNumber = 0;
                string line = file.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(lineNumber + "." + line);
                    writeFile.WriteLine(lineNumber + "." + line);
                    lineNumber++;
                    line = file.ReadLine();
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("New file is created, check .cs directory");
        return;
    }
}

