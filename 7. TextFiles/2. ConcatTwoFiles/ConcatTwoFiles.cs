using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that concatenates two text files into another text file.
 */

class ConcatTwoFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader(@"..\..\test1.txt");
        StreamReader secondFile = new StreamReader(@"..\..\test2.txt");
        using (firstFile)
        {
            using (secondFile)
            {
                ConcatFiles(firstFile, secondFile);
            }
        }        
    }

    static void ConcatFiles(StreamReader first, StreamReader second)
    {      
        StreamWriter finalFile = new StreamWriter(@"..\..\concat.txt");

        string firstFileLine = first.ReadLine();
        string secondFileLine = second.ReadLine();

        using (finalFile)
        {
            while (firstFileLine != null || secondFileLine != null)
            {
                if (firstFileLine != null)
                {
                    finalFile.WriteLine(firstFileLine);
                    firstFileLine = first.ReadLine();
                }
                else
                {
                    finalFile.WriteLine(secondFileLine);
                    secondFileLine = second.ReadLine();
                }
            }
        }
        Console.WriteLine("File is ready! Check your .cs directory");      
        return;
    }
}

