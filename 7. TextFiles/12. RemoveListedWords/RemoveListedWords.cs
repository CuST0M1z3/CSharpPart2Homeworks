using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that removes from a text file all words listed in given another text file. 
 * Handle all possible exceptions in your methods.
 */

class RemoveListedWords
{
    static void Main()
    {
        DeleteWord();
    }
    static void DeleteWord()
    {
        try
        {
            List<string> wordsToDelete = new List<string>();
            using (StreamReader wordToDelete = new StreamReader(@"..\..\wordstoremove.txt")) // check your .cs directory
            {
                string lines = wordToDelete.ReadLine();
                while (lines != null)
                {
                    wordsToDelete.Add(lines);
                    lines = wordToDelete.ReadLine();
                }
            }
            string result = String.Empty;
            string finalResult = String.Empty;
            using (StreamReader inputFile = new StreamReader(@"..\..\test.txt")) // check your .cs directory
            {
                string line = inputFile.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    foreach (var item in wordsToDelete)
                    {
                        string removeWord = String.Format(@"\b {0}\b", item);
                        result = ((Regex.Replace(line, removeWord, String.Empty)));
                        if (result != line)
                        {
                            finalResult = result;
                        }
                    }
                    Console.WriteLine(finalResult);
                    Console.WriteLine();
                    line = inputFile.ReadLine();
                }
            }
            return;
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

