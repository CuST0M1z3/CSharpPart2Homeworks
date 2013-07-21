using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that reads a list of words from a file words.txt and finds how many 
 * times each of the words is contained in another file test.txt. 
 * The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
 * Handle all possible exceptions in your methods.
 */

class FindAndSort
{
    static void Main()
    {
        FindSort();
    }
    static void FindSort()
    {
        try
        {
            using (StreamWriter result = new StreamWriter(@"..\..\result.txt")) // check your .cs directory
            {
                List<string> wordsToSearch = new List<string>();
                List<string> counting = new List<string>();
                using (StreamReader wordToSearch = new StreamReader(@"..\..\words.txt")) // check your .cs directory
                {
                    string lines = wordToSearch.ReadLine();
                    while (lines != null)
                    {
                        wordsToSearch.Add(lines);
                        lines = wordToSearch.ReadLine();
                    }
                }
                int count = 0;
                using (StreamReader inputFile = new StreamReader(@"..\..\test.txt")) // check your .cs directory
                {
                    string text = inputFile.ReadToEnd();
                    foreach (var item in wordsToSearch)
                    {
                        count = 0;
                        string searchingWord = String.Format(@" {0} ", item);
                        int index = text.IndexOf(searchingWord, 0);
                        while (index != -1)
                        {
                            count++;
                            index = text.IndexOf(searchingWord, index + 1);
                        }
                        counting.Add(count.ToString() + " " + "times" + " " + item);
                        counting.Sort();
                    }
                }
                for (int i = counting.Count - 1; i >= 0; i--)
                {
                    result.WriteLine(counting[i]);
                    Console.WriteLine(counting[i]);
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

