using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
 * <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
 * Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 * 
 * <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
 * Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

*/

class ReplacesInHTML
{
    static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        Console.WriteLine(Regex.Replace(text, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
    }
}

