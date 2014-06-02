using System;
using System.Collections.Generic;

class Program
{
    private static int GetOnes(int[,] matrix, int row, int col)
    {
        int counter = 0;
        if (matrix[row - 1, col - 1] == 1) counter++;
        if (matrix[row - 1, col] == 1) counter++;
        if (matrix[row - 1, col + 1] == 1) counter++;
        if (matrix[row, col - 1] == 1) counter++;
        if (matrix[row, col + 1] == 1) counter++;
        if (matrix[row + 1, col - 1] == 1) counter++;
        if (matrix[row + 1, col] == 1) counter++;
        if (matrix[row + 1, col + 1] == 1) counter++;
        return counter;
    }

    static void Main()
    {
        //<fill the matrix>
        int[,] matrix = new int[16, 16];
        for (int i = 0; i < 16; i++)
        {
            string binaryString = Console.ReadLine();
            int number = Convert.ToInt32(binaryString, 2);
            int counter = 15;
            for (int j = 0; j < 16; j++)
            {
                matrix[i, j] = (number >> counter) & 1;
                counter--;
            }
        }
        //</fill the matrix>
        //<capacitors count>
        int leftCapacitorsCount = 0;
        int rightCapacitorsCount = 0;
        for (int i = 1; i < 15; i++)
        {
            for (int j = 1; j < 15; j++)
            {
                if (matrix[i, j] == 0)
                {
                    if (GetOnes(matrix, i, j) == 8)
                    {
                        if (0 < j && j < 8)
                        {
                            leftCapacitorsCount++;
                        }
                        else if (7 < j && j < 15)
                        {
                            rightCapacitorsCount++;
                        }
                    }
                }
            }
        }
        //</capacitors count>
        while (true)
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "hover":
                    {
                        int row = int.Parse(Console.ReadLine());
                        int col = int.Parse(Console.ReadLine());
                        if (matrix[row, col] == 1)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                    break;
                case "operate":
                    {
                        int row = int.Parse(Console.ReadLine());
                        int col = int.Parse(Console.ReadLine());
                        if (matrix[row, col] == 0)
                        {
                            if (row == 0 || row == 15 || col == 0 || col == 15)
                            {
                                break;
                            }
                            if (GetOnes(matrix, row, col) == 8)
                            {
                                matrix[row - 1, col - 1] = 0;
                                matrix[row - 1, col] = 0;
                                matrix[row - 1, col + 1] = 0;
                                matrix[row, col - 1] = 0;
                                matrix[row, col + 1] = 0;
                                matrix[row + 1, col - 1] = 0;
                                matrix[row + 1, col] = 0;
                                matrix[row + 1, col + 1] = 0;
                                if (0 < col && col < 8)
                                {
                                    leftCapacitorsCount--;
                                }
                                else if (7 < col && col < 15)
                                {
                                    rightCapacitorsCount--;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("missed");
                            Console.WriteLine((leftCapacitorsCount + rightCapacitorsCount).ToString());
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }
                    break;
                case "cut":
                    {
                        string wire = Console.ReadLine();
                        if (wire == "red")
                        {
                            if (leftCapacitorsCount == 0)
                            {
                                Console.WriteLine(rightCapacitorsCount.ToString());
                                Console.WriteLine("disarmed");
                            }
                            else
                            {
                                Console.WriteLine(leftCapacitorsCount.ToString());
                                Console.WriteLine("BOOM");
                            }
                        }
                        else if (wire == "blue")
                        {
                            if (rightCapacitorsCount == 0)
                            {
                                Console.WriteLine(leftCapacitorsCount.ToString());
                                Console.WriteLine("disarmed");
                            }
                            else
                            {
                                Console.WriteLine(rightCapacitorsCount.ToString());
                                Console.WriteLine("BOOM");
                            }
                        }
                        return;
                    }
            }
        }

    }
}

