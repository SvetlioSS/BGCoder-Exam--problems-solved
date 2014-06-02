using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static int[,] Reset(int[,] matrix, int length)
    {
        for (int i = 1; i < length; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[j, i] == 1)
                {
                    int cellCol = i;
                    while (true)
                    {
                        if (cellCol == 0 || matrix[j, cellCol - 1] == 1)
                        {
                            matrix[j, i] = 0;
                            matrix[j, cellCol] = 1;
                            break;
                        }
                        cellCol--;
                    }
                }
            }
        }
        return matrix;
    }
    private static int[,] MoveLeft(int[,] matrix, int startRow, int startCol)
    {
        for (int i = 1; i <= startCol; i++)
        {
            if (matrix[startRow, i] == 1)
            {
                int cellCol = i;
                while (true)
                {
                    if (cellCol == 0 || matrix[startRow, cellCol - 1] == 1)
                    {
                        matrix[startRow, i] = 0;
                        matrix[startRow, cellCol] = 1;
                        break;
                    }
                    cellCol--;
                }
            }
        }
        return matrix;
    }
    private static int[,] MoveRight(int[,] matrix, int startRow, int startCol, int length)
    {
        for (int i = length - 1; i >= startCol; i--)
        {
            if (matrix[startRow, i] == 1)
            {
                int cellCol = i;
                while (true)
                {
                    if (cellCol == length - 1 || matrix[startRow, cellCol + 1] == 1)
                    {
                        matrix[startRow, i] = 0;
                        matrix[startRow, cellCol] = 1;
                        break;
                    }
                    cellCol++;
                }
            }
        }
        return matrix;
    }
    private static ulong Count(int[,] matrix, int length)
    {
        ulong countOfZeroColumns = 0;
        ulong sum = 0;
        //count the sum of the columns
        for (int i = 0; i < 8; i++)
        {
            string binaryString = "";
            for (int j = 0; j < length; j++)
            {
                binaryString += matrix[i, j].ToString();
            }
            sum += Convert.ToUInt64(binaryString, 2);
        }
        //count the zero columns
        for (int i = 0; i < length; i++)
        {
            int counter = 0;
            for (int j = 0; j < 8; j++)
            {
                if (matrix[j, i] == 1)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                countOfZeroColumns++;
            }
        }
        return sum * countOfZeroColumns;
    }
    static void Main(string[] args)
    {
        //fill the matrix
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[8, n];
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            int ctr = n - 1;
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (number >> ctr) & 1;
                ctr--;
            }
        }
        bool finished = false;
        while (true)
        {
            string word = Console.ReadLine();
            switch (word)
            {
                case "reset":
                    {
                        matrix = Reset(matrix, n);
                        break;
                    }
                case "right":
                    {
                        int row = int.Parse(Console.ReadLine());
                        if (row > 7) row = 7;
                        if (row < 0) row = 0;
                        int col = int.Parse(Console.ReadLine());
                        if (col > n - 1) col = n - 1;
                        if (col < 0) col = 0;
                        matrix = MoveRight(matrix, row, col, n);
                        break;
                    }
                case "left":
                    {
                        int row = int.Parse(Console.ReadLine());
                        if (row > 7) row = 7;
                        if (row < 0) row = 0;
                        int col = int.Parse(Console.ReadLine());
                        if (col > n - 1) col = n - 1;
                        if (col < 0) col = 0;
                        matrix = MoveLeft(matrix, row, col);
                        break;
                    }
                case "stop":
                    {
                        Console.WriteLine(Count(matrix, n));
                        finished = true;
                        break;
                    }
            }
            if (finished)
            {
                break;
            }
        }
    }
}

