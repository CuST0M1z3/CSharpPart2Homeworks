using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A dictionary is stored as a sequence of text lines containing words and their explanations. 
 * Write a program that enters a word and translates it by using the dictionary. 
.NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes
 */

class Dictionary
{
    static void Main()
    {
        IDictionary<string, string> translateWords = new Dictionary<string, string>();
        translateWords[".NET"] = "platform for applications from Microsoft";
        translateWords["CLR"] = "managed execution environment for .NET";
        translateWords["namespace"] = "hierarchical organization of classes";

        Console.Write("Enter a choice: 1 for .NET, 2 for CLR, or 3 for namespace: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 1 || number > 3)
        {
            Console.WriteLine("Invalid choice");
            return;
        }
        string name = String.Empty;

        switch (number)
        {
            case 1:
                name = ".NET";
                break;
            case 2:
                name = "CLR";
                break;
            case 3:
                name = "namespace";
                break;
        }

        TranslateWord(name, translateWords);
     }
    static void TranslateWord(string name, IDictionary<string, string> word)
    {
        if (word.ContainsKey(name))
        {
            string value = word[name];
            Console.WriteLine("{0} - {1}", name, value);
        }
        return;
    }
}

