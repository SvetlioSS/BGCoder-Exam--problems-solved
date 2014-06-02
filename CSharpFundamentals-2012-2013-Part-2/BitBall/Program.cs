using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];
        //<fill matrix>
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                if (((number >> j) & 1) == 1)
                {
                    matrix[i, j] = 2;
                }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {

                if (((number >> j) & 1) == 1)
                {
                    if (matrix[i, j] == 2)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 3;
                    }
                }
            }
        }
        //</fill matrix>
        int goalForBTeam = 0;
        int goalForTTeam = 0;
        //<team attacks>
        for (int i = 7; i >= 0; i--)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[j, i] == 3)
                {
                    int rowCell = j;
                    while (true)
                    {
                        if (rowCell == 0)
                        {
                            goalForBTeam++;
                            break;
                        }
                        else if (matrix[rowCell - 1, i] == 2 || matrix[rowCell - 1, i] == 3)
                        {
                            break;
                        }
                        rowCell--;
                    }
                }
                else if (matrix[j, i] == 2)
                {
                    int rowCell = j;
                    while (true)
                    {
                        if (rowCell == 7)
                        {
                            goalForTTeam++;
                            break;
                        }
                        else if (matrix[rowCell + 1, i] == 2 || matrix[rowCell + 1, i] == 3)
                        {
                            break;
                        }
                        rowCell++;
                    }                    
                }
            }
        }
        Console.WriteLine("{0}:{1}", goalForTTeam, goalForBTeam);
        //</team attacks>
    }
}

