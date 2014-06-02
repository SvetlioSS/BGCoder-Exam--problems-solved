using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        long number1 = long.Parse(Console.ReadLine());
        long number2 = long.Parse(Console.ReadLine());
        long number3 = long.Parse(Console.ReadLine());
        long number4 = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long[,] rectangle = new long[rows, cols];
        rectangle[0, 0] = number1;
        rectangle[0, 1] = number2;
        rectangle[0, 2] = number3;
        rectangle[0, 3] = number4;
        int col = 0;
        for (int row = 0; row < rows; row++)
        {
            if (row == 0)
            {
                col = 4;
            }
            else
            {
                col = 0;
            }
            while (col < cols)
            {
                rectangle[row, col] = number1 + number2 + number3 + number4;
                number1 = number2;
                number2 = number3;
                number3 = number4;
                number4 = rectangle[row, col];
                col++;
            }
        }
        Console.WriteLine();
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < cols; column++)
            {
                Console.Write(rectangle[row, column]);
                if (column != cols - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

