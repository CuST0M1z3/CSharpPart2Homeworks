using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
 */

class SortStrings
{
    static void Main()
    {
        ReadSortAndWrite();
    }
    static void ReadSortAndWrite()
    {
        List<string> stringToSort = new List<string>();
        using (StreamWriter outputFile = new StreamWriter(@"..\..\outputfile.txt")) // check your .cs directory
        {
            using (StreamReader inputFile = new StreamReader(@"..\..\inputfile.txt")) 
            {
                string line = inputFile.ReadLine();
                while (line != null)
                {
                    stringToSort.Add(line);
                    line = inputFile.ReadLine();
                }
            }
            stringToSort.Sort();
            foreach (var word in stringToSort)
            {
                Console.WriteLine(word);
                outputFile.WriteLine(word);
            }
        }
        return;
    }
}

