using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that compares two text files line by line and prints the number of lines that 
 * are the same and the number of lines that are different. Assume the files have equal number of lines.
 */

class CompareTextFiles
{
        static void Main()
    {
        StreamReader firstFile = new StreamReader(@"..\..\test1.txt");
        StreamReader secondFile = new StreamReader(@"..\..\test2.txt"); 
        ConcatFiles(firstFile, secondFile);
    }

    static void ConcatFiles(StreamReader first, StreamReader second)
    {
        int equalLines = 0;
        int notEqualLines = 0;

        int  firstFileLineCount = File.ReadLines(@"..\..\test1.txt").Count(); //if you wanna see files check your .cs directory
        int  secondFileLineCount = File.ReadLines(@"..\..\test2.txt").Count();

        if (firstFileLineCount == secondFileLineCount)
        {
            using (first)
            {
                using (second)
                {
                    string firstFileLine = first.ReadLine();
                    string secondFileLine = second.ReadLine();

                    while (firstFileLine != null && secondFileLine != null && (firstFileLineCount == secondFileLineCount))
                    {
                        if (firstFileLine.Equals(secondFileLine))
                        {
                            equalLines++;
                        }
                        else
                        {
                            notEqualLines++;
                        }
                        firstFileLine = first.ReadLine();
                        secondFileLine = second.ReadLine();
                    }
                }
            }
            Console.WriteLine("Equal lines are: " + equalLines);
            Console.WriteLine("Not equal lines are: " + notEqualLines);
        }
        else
        {
            Console.WriteLine("One of the file have more lines than the other");
        }
        return;
    }
}

