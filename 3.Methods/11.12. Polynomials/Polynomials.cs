using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Polynomials
{
    static void Main()
    {
        decimal[] firstPolynomial = { 3, 2, -1, 0, 4, -3 };
        decimal[] secondPolynomial = { 1, 3, 2, -1 };

        int maxMultiplyLength = firstPolynomial.Length + secondPolynomial.Length;
        decimal[] mul = new decimal[maxMultiplyLength];

        PolynomialRepresentation(firstPolynomial);
        PolynomialRepresentation(secondPolynomial);
        decimal[] addArray = (AddPolynomials(firstPolynomial, secondPolynomial)).ToArray();
        decimal[] subArray = (SubstractingPolynomials(firstPolynomial, secondPolynomial)).ToArray();
        decimal[] mulArray = (MultiplyPolynomials(firstPolynomial, secondPolynomial, mul)).ToArray();

        Console.WriteLine("Sum is: ");
        PolynomialRepresentation(addArray);

        Console.WriteLine("Substraction is: ");
        PolynomialRepresentation(subArray);

        Console.WriteLine("Multiplication is:");
        PolynomialRepresentation(mulArray);

    }

    static decimal[] MultiplyPolynomials(decimal[] array1, decimal[] array2, decimal[] dec)
    {

        for (int i = 0; i < dec.Length; i++)
        {
            dec[i] = 0;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                int position = i + j;
                dec[position] += (array1[i] * array2[j]);
            }            
        }

        return dec;
    }

    static List<decimal> SubstractingPolynomials(decimal[] array1, decimal[] array2)
    {
        List<decimal> addingPol = new List<decimal>();

        if (array1.Length >= array2.Length)
        {
            int i = 0;
            while (i < array2.Length)
            {
                addingPol.Add(array1[i] - array2[i]);
                i++;
            }
            while (i >= array2.Length && i < array1.Length)
            {
                addingPol.Add(array1[i]);
                i++;
            }
        }
        if (array1.Length < array2.Length)
        {
            int i = 0;
            while (i < array1.Length)
            {
                addingPol.Add(array1[i] - array2[i]);
                i++;
            }
            while (i >= array1.Length && i < array2.Length)
            {
                addingPol.Add(array2[i]);
                i++;
            }
        }

        return addingPol;
    }

    static List<decimal> AddPolynomials(decimal[] array1, decimal[] array2)
    {
        List<decimal> addingPol = new List<decimal>();

        if (array1.Length >= array2.Length)
        {
            int i = 0;
            while (i < array2.Length)
            {
                addingPol.Add(array1[i] + array2[i]);
                i++;
            }
            while (i >= array2.Length && i < array1.Length)
            {
                addingPol.Add(array1[i]);
                i++;
            }
        }
        if (array1.Length < array2.Length)
        {
            int i = 0;
            while (i < array1.Length)
            {
                addingPol.Add(array1[i] + array2[i]);
                i++;
            }
            while (i >= array1.Length && i < array2.Length)
            {
                addingPol.Add(array2[i]);
                i++;
            }
        }

        return addingPol;

    }

    static void PolynomialRepresentation(decimal[] array)
    {

        List<string> code = new List<string>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                code.Add("+");
            }
            else
            {
                code.Add(" ");
            }
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0 && array[i] > 0)
            {
                Console.Write(array[i]);
            }
            else if (i == 0 && array[i] < 0)
            {
                Console.Write("(" + array[i] + ")");
            }
            else if (i != 0 && array[i] > 0)
            {
                Console.Write(array[i] + "x^" + i + code[0]);
            }
            else if (i != 0 && array[i] < 0)
            {
                Console.Write("(" + array[i] + "x^" + i + ")" + code[0]);
            }
        }
        Console.WriteLine();

    }
}


