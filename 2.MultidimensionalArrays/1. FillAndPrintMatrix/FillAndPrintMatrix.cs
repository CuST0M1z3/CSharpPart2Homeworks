using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillAndPrintMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[n, n];

        PrintMatrixA(array, n);
        PrintMatrixB(array, n);
        PrintMatrixC(array, n);
    }

    static void PrintMatrixA(int[,] array, int n)
    {
        int index = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                array[row, col] = index;
                index++;
            }
        }
        Print(array, n);
    }

    static void PrintMatrixB(int[,] array, int n)
    {
        int index = 1;
        int lastRow = 0;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = lastRow; row < n; row++)
                {
                    array[row, col] = index;
                    index++;
                    lastRow = row;
                }
            }
            else
            {
                for (int row = lastRow; row >= 0; row--)
                {
                    array[row, col] = index;
                    index++;
                    lastRow = row;
                }
            }
            
        }
        Print(array, n);
    }

    static void PrintMatrixC(int[,] array, int n)
    {
        int index = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                array[n - row + col - 1, col] = index;
                index++;
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                array[row - col, n - col - 1] = index;
                index++;
            }
        }
               
        Print(array, n);
    }

    static void Print(int[,] array, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

