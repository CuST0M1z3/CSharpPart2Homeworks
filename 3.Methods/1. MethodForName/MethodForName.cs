using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MethodForName
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string name = Console.ReadLine();

        PrintName(name);
    }

    static void PrintName(string name)
    {
        Console.WriteLine("\"Hello, {0}!\"", name);
    }
}

