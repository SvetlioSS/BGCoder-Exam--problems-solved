using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    private static uint MoveRight(uint[] matrix, int rowCount, uint num)
    {
        uint n = matrix[rowCount];
        if ((((num >> 1) & n) == 0) && num % 2 == 0)
        {
            num = num >> 1;
        }
        return num;
    }

    private static uint MoveLeft(uint[] matrix, int rowCount, uint num)
    {
        uint n = matrix[rowCount];
        if ((((num << 1) & n) == 0) && num <= 127)
        {
            num = num << 1;
        }
        return num;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        uint[] matr = new uint[4];
        ulong output = 0;
        for (int i = 0; i < n / 4; i++)
        {
            uint number = uint.Parse(Console.ReadLine());
            //<fill matrix>
            uint mask = 255;
            uint num = mask & number; //we store the first 8 bits
            uint leadingOnesNum = (~mask) & number; //we store the all the bits except the first 8
            //</fill matrix>
            bool ignoreAll = false;
            for (int j = 0; j < 3; j++) //take 3 commands for each number
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "R":
                        num = MoveRight(matr, j, num);
                        break;
                    case "L":
                        num = MoveLeft(matr, j, num);
                        break;
                    case "D":
                        break;
                }                
                uint tm = num & matr[j+1];
                if (ignoreAll == false)
                {
                    if (tm != 0) //check if the peace is at the bottom
                    {
                        matr[j] = num | matr[j]; //put the peace at the bottom
                        if (matr[j] == 255) //check if it is 255, if it is it calculates output make the row null and move everything down
                        {
                            output += ((ulong)Convert.ToString((leadingOnesNum | num), 2).Count(x => x == '1')) * 10;
                            matr[j] = 0;
                            for (int k = j; k >= 0 ; k--)
                            {
                                if (k == 0)
                                {
                                    matr[k] = 0;
                                }
                                else
                                {
                                    matr[k] = matr[k - 1];
                                }
                            }
                        }
                        else //if it is not 255 only calculate output
                        {
                            output += ((ulong)Convert.ToString((leadingOnesNum | num), 2).Count(x => x == '1'));
                        }
                        ignoreAll = true;
                    }
                    else if (tm == 0 && j == 2) //also checks if the peace is at the bottom, but the bottom of the matrix
                    {
                        matr[j+1] = num | matr[j+1];
                        if (matr[j + 1] == 255)
                        {
                            output += ((ulong)Convert.ToString((leadingOnesNum | num), 2).Count(x => x == '1')) * 10;
                            matr[j + 1] = 0;
                            for (int k = 3; k >= 0; k--)
                            {
                                if (k == 0)
                                {
                                    matr[k] = 0;
                                }
                                else
                                {
                                    matr[k] = matr[k - 1];
                                }
                            }
                        }
                        else
                        {
                            matr[3] = num | matr[3];
                            output += ((ulong)Convert.ToString((leadingOnesNum | num), 2).Count(x => x == '1'));
                        }
                        ignoreAll = true;
                    }
                }
            }
        }
        Console.WriteLine(output);
    }
}

