using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        int count = 0;
        int index = text.IndexOf("in", 0);
        while (index != -1)
        {
            count++;
            index = text.IndexOf("in", index + 1, StringComparison.CurrentCultureIgnoreCase);
        }
        Console.WriteLine("The result is: " + count);
    }
}

