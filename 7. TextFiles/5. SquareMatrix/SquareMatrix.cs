using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area 
 * of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
 * Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4			17
3 7 1 2
4 3 3 2
 */

class SquareMatrix
{
    static void Main()
    {
        StreamReader matrix = new StreamReader(@"..\..\inputfile.txt");
        SumOfArea2x2(ReadAMatrixFromFile(matrix));
    }

    static int[,] ReadAMatrixFromFile(StreamReader matrix)
    {
        using (matrix)
        {
            int size = int.Parse(matrix.ReadLine());
            int[,] m = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                string line = matrix.ReadLine();
                string[] numbers = line.Split(' ');
                for (int col = 0; col < size; col++)
                {
                    m[row, col] = int.Parse(numbers[col]);
                }
            }
            return m;
        }      
    }

    static void SumOfArea2x2(int[,] m)
    {
        using (StreamWriter sum = new StreamWriter(@"..\..\sumfile.txt"))
        {
            int maxPlatformX = 2;
            int maxPlatformY = 2;
            int maxSum = int.MinValue;
            for (int row = 0; row < m.GetLength(0) - maxPlatformX + 1; row++)
            {
                for (int col = 0; col < m.GetLength(1) - maxPlatformY + 1; col++)
                {
                    int currentSum = 0;
                    for (int platformX = row; platformX < maxPlatformX + row; platformX++)
                    {
                        for (int platformY = col; platformY < maxPlatformY + col; platformY++)
                        {
                            currentSum += m[platformX, platformY];
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine("Max sum is: " + maxSum);
            sum.WriteLine(maxSum); // You can check new file at your .cs directory
        }
        return;
    }
}

