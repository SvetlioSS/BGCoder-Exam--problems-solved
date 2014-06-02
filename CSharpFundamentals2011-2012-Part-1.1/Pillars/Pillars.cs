using System;

class Program
{
    static void Main()
    {
        //create matrix of bits
        int n = 8;
        int[,] matrix = new int[8, 8];
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                int bit = (number >> j) & 1;
                matrix[i, j] = bit;
            }
        }
        string printPillar = "";
        for (int pillar = 7; pillar >= 0; pillar--)
        {
            int pointsLeft = 0;
            int pointsRight = 0;
            for (int col = n - 1; col > pillar ; col--)
            {
                for (int row = 0; row <= n - 1; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        pointsLeft++;
                    }
                }
            }
            for (int col = pillar - 1; col >= 0; col--)
            {
                for (int row = 0; row <= n - 1; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        pointsRight++;
                    }
                }
            }
            if (pointsLeft == pointsRight)
            {
                printPillar += pillar.ToString() + "\n";
                printPillar += pointsLeft.ToString();
                break;
            }
        }
        if (printPillar == "")
        {
            printPillar += "No";
        }
        Console.WriteLine(printPillar);
    }
}

