using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to convert hexadecimal numbers to their decimal representation.
 */

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter hex value: ");
        string hex = Console.ReadLine();

        Console.Write("Decimal value is: ");
        HexToDec(hex);
    }

    static void HexToDec(string hex)
    {
        int dec = 0;
        int j = hex.Length - 1;

        for (int i = 0; i < hex.Length; i++)
        {
            if ((hex[i] - '0') >= 10)
            {
                switch (hex[i])
                {
                    case 'A':
                        dec += (10 * ((int)Math.Pow(16, j)));
                        j--;
                        break;
                    case 'B':
                        dec += (11 * ((int)Math.Pow(16, j)));
                        j--;
                        break;
                    case 'C':
                        dec += (12 * ((int)Math.Pow(16, j)));
                        j--;
                        break;
                    case 'D':
                        dec += (13 * ((int)Math.Pow(16, j)));
                        j--;
                        break;
                    case 'E':
                        dec += (14 * ((int)Math.Pow(16, j)));
                        j--;
                        break;
                    case 'F':
                        dec += (15 * ((int)Math.Pow(16, j)));
                        j--;
                        break;
                }

            }
            else
            {
                dec += ((hex[i] - '0') * ((int)Math.Pow(16, j)));
                j--;
            }          
        }
        Console.WriteLine(dec);
    }
}

