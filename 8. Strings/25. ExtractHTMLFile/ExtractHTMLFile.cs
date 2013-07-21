using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:
 * <html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>

 */

class ExtractHTMLFile
{
    static void Main()
    {
        string htmlTag = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskillful .NET software engineers.</p></body></html>";

        StringBuilder withoutTags = new StringBuilder();

        bool openTag = false;


        for (int i = 0; i < htmlTag.Length; i++)
        {
            if (htmlTag[i] == '<')
            {
                openTag = true;
            }
            if (openTag == false)
            {
                withoutTags.Append(htmlTag[i]);
                if (((i + 1) < htmlTag.Length - 1) && (htmlTag[i + 1] == '<'))
                {
                    withoutTags.AppendLine();
                }
            }
            if (htmlTag[i] == '>')
            {
                openTag = false;
            }
        }
        Console.WriteLine((withoutTags.ToString()).Trim());
    }
}

