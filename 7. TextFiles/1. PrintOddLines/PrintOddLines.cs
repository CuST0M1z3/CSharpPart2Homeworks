using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a text file and prints on the console its odd lines.
 */

class PrintOddLines
{
    static void Main()
    {
        StreamReader readFile = new StreamReader(@"..\..\test.txt");
        OddLinesPrint(readFile);
    }

    static void OddLinesPrint(StreamReader file)
    {
        using (file)
        {
            int lineNumber = 0;
            string line = file.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(lineNumber + "." + line);
                }
                lineNumber++;
                line = file.ReadLine();
            }
        }
    }
}

