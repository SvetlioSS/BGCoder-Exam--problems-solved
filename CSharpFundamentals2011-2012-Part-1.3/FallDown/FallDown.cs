using System;

class FallDown
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = (number >> j) & 1;
            }
        }
        for (int row = 6; row >= 0; row--)
        {
            for (int col = 7; col >= 0; col--)
            {
                if (matrix[row,col] == 1)
                {
                    int dropRow = row;
                    while (matrix[dropRow + 1, col] == 0)
                    {
                        matrix[dropRow, col] = 0;
                        matrix[dropRow + 1, col] = 1;
                        dropRow++;
                        if (dropRow == 7)
                        {
                            matrix[dropRow, col] = 1;
                            break;
                        }
                    }
                }
            }
        }
        for (int row = 0; row < 8; row++)
        {
            string num1 = "";
            for (int col = 7; col >= 0; col--)
            {
                num1 += matrix[row, col];
            }
            Console.WriteLine(Convert.ToInt32(num1,2));
        }
    }
}

