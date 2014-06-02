using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBit1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = (num >> j) & 1;
                }
            }
            string direction = "south";
            string previousDirection = "south";
            int row = 0;
            int col = 0;
            int track = 1;
            int turns = 0;
            while (true)
            {
                if (matrix[0, 0] == 1)
                {
                    track--;
                    break;
                }
                if (direction == "south")
                {
                    if ((row == 7) || matrix[row + 1, col] == 1)
                    {
                        if (col == 7 || matrix[row, col + 1] == 1)
                        {
                            break;
                        }
                        previousDirection = "south";
                        direction = "west";
                        track++;
                        turns++;
                        col++;
                    }
                    else if (matrix[row + 1, col] == 0)
                    {
                        row++;
                        track++;
                    }
                }
                if (direction == "west")
                {
                    if ((col == 7) || (matrix[row, col + 1] == 1))
                    {
                        if (previousDirection == "south")
                        {
                            if (row == 0 || matrix[row - 1, col] == 1)
                            {
                                break;
                            }
                            previousDirection = "west";
                            direction = "north";
                            row--;
                        }
                        else
                        {
                            if (row == 7 || matrix[row + 1, col] == 1)
                            {
                                break;
                            }
                            previousDirection = "west";
                            direction = "south";
                            row++;
                        }
                        track++;
                        turns++;
                    }
                    else if (matrix[row, col + 1] == 0)
                    {
                        col++;
                        track++;
                    }
                }
                if (direction == "north")
                {
                    if ((row == 0) || (matrix[row - 1, col] == 1))
                    {
                        if (col == 7 || matrix[row, col + 1] == 1)
                        {
                            break;
                        }
                        previousDirection = "north";
                        direction = "west";
                        track++;
                        turns++;
                        col++;
                    }
                    else if (matrix[row - 1, col] == 0)
                    {
                        row--;
                        track++;
                    }
                }
            }
            if (row == 7 && col == 7)
            {
                Console.Write(track + " ");
                Console.Write(turns);
                Console.WriteLine();
            }
            else
            {
                Console.Write("No ");
                Console.Write(track);
                Console.WriteLine();
            }
        }
    }
}
