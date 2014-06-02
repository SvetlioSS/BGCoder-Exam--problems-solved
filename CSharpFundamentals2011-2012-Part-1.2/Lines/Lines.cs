using System;

class Lines
{
    static void Main()
    {
        //fill matrix
        int[,] matrix = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int position = 7;
            int mask = 1;
            for (int j = 0; j < 8; j++)
            {
                matrix[i, position] = ((mask << j) & num) >> j;
                position--;
            }
        }
        int longestLine = 0;
        int longestCount = 0;
        //check for horizontal lines
        for (int i = 0; i < 8; i++)
        {
            int currentLine = 0;
            for (int j = 0; j < 8; j++)
            {
                while (j < 8 && matrix[i, j] == 1)
                {
                    currentLine++;
                    j++;
                }
                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestCount++;
                }
                currentLine = 0;
            }
        }
        //check for vertical lines
        for (int j = 0; j < 8; j++)
        {
            int currentLine = 0;
            for (int i = 0; i < 8; i++)
            {
                while (i < 8 && matrix[i, j] == 1)
                {
                    currentLine++;
                    i++;
                }
                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestCount++;
                }
                currentLine = 0;
            }
        }
        if (longestLine == 1)
        {
            longestCount /= 2;
        }
        Console.WriteLine(longestLine);
        Console.WriteLine(longestCount);
    }
}

