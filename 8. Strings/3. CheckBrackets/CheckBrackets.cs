using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
 */

class CheckBrackets
{
    static void Main()
    {
        string firstExp = "((a+b)/5-d)";
        string secondExp = ")(a+b)";
        CheckPutOfBrackets(firstExp);
        CheckPutOfBrackets(secondExp);
    }

    static void CheckPutOfBrackets(string expression)
    {
        int bracket = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                bracket++;
            }
            else if (expression[i] == ')')
            {
                bracket--;
            }
            if (bracket < 0)
            {
                Console.WriteLine("Brackets are not correct");
                break;
            }
        }
        if (bracket >= 0)
        {
            Console.WriteLine("Brackets are correct");
        }
    }
}

