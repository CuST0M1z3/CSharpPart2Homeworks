using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that extracts from given XML file all the text without the tags. */

class TextWithoutTags
{
    static void Main()
    {
        WithoutText();
    }

    static void WithoutText()
    {
        bool openTag = false;
        StringBuilder text = new StringBuilder();
        List<string> words = new List<string>();
        using (StreamReader inputFile = new StreamReader(@"..\..\inputfile.txt"))
        {
            string line = inputFile.ReadLine();
            while (line != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '<')
                    {
                        openTag = true;
                    }
                    if (openTag == false)
                    {
                        text.Append(line[i]);
                        if (((i+1) < line.Length - 1) && (line[i + 1] == '<'))
                        {
                            text.AppendLine();
                        }
                    }
                    if (line[i] == '>')
                    {
                        openTag = false;
                    }
                }
                line = inputFile.ReadLine();
            }          
        }
        Console.WriteLine((text.ToString()).Trim());
        return;
    }
}

