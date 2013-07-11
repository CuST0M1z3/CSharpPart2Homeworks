using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EqualStringInMatrix
{
    static void Main()
    {
        string[,] matrix = 
        {
            {"ha", "ha", "ha", "hi"},
            {"hi", "hi", "hi", "hi"},
            {"yy", "xx", "he", "xx"}
        };

        MaxSequence(matrix);
    }

    static void MaxSequence(string[,] array)
    {
        int max = 0;
        int maxCount = 1;

        string stringSequence = "";

        List<string> m = new List<string>();
  
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                max = Searching(array, row, col + 1, maxCount, "right");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
                max = Searching(array, row + 1, col, maxCount, "down");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
                max = Searching(array, row, col - 1, maxCount, "left");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
                max = Searching(array, row - 1, col, maxCount, "up");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
                max = Searching(array, row - 1, col + 1, maxCount, "right-up-diagonal");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
                max = Searching(array, row + 1, col + 1, maxCount, "right-down-diagonal");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
                max = Searching(array, row - 1, col - 1, maxCount, "left-up-diagonal");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
                max = Searching(array, row + 1, col - 1, maxCount, "left-down-diagonal");
                if (max > maxCount)
                {
                    maxCount = max;
                    stringSequence = array[row, col];
                }
            }
        }
        Console.WriteLine("The max sequence is: " + maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            m.Add(stringSequence);
        }
        Console.Write("{");
        foreach (var item in m)
        {
            Console.Write(" " + item + " ");
        }
        Console.Write("}");
    }

    static int Searching(string[,] array, int row, int col, int maxCount , string direction)
    {
        int count = 1;
        if (row < 0 || col < 0 || row >= array.GetLength(0) || col >= array.GetLength(1))
        {
            return maxCount;
        }
        else
        {
            if (direction == "right")
            {
                string stringToSearch = array[row, col - 1];
                for (int currentCol = col; currentCol < array.GetLength(1); currentCol++)
                {
                    if (stringToSearch == array[row, currentCol])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }                
            }
            if (direction == "down")
            {
                string stringToSearch = array[row - 1, col];
                for (int currentRow = row; currentRow < array.GetLength(0); currentRow++)
                {
                    if (stringToSearch == array[currentRow, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            if (direction == "left")
            {
                string stringToSearch = array[row, col + 1];
                for (int currentCol = col; currentCol >= 0; currentCol--)
                {
                    if (stringToSearch == array[row, currentCol])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            if (direction == "up")
            {
                string stringToSearch = array[row + 1, col];
                for (int currentRow = row; currentRow >= 0; currentRow--)
                {
                    if (stringToSearch == array[currentRow, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            if (direction == "right-up-diagonal")
            {
                string stringToSearch = array[row + 1, col - 1];
                while (row >= 0 && col < array.GetLength(1))
                {
                    if (stringToSearch == array[row, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    row--;
                    col++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            if (direction == "right-down-diagonal")
            {
                string stringToSearch = array[row - 1, col - 1];
                while (row < array.GetLength(0) && col < array.GetLength(1))
                {
                    if (stringToSearch == array[row, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    row++;
                    col++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            if (direction == "left-up-diagonal")
            {
                string stringToSearch = array[row + 1, col + 1];
                while (row >= 0 && col >= 0)
                {
                    if (stringToSearch == array[row, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    row--;
                    col--;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            if (direction == "left-down-diagonal")
            {
                string stringToSearch = array[row - 1, col + 1];
                while (row < array.GetLength(0) && col >= 0)
                {
                    if (stringToSearch == array[row, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    row++;
                    col--;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
        }
        return maxCount;
    }

}

