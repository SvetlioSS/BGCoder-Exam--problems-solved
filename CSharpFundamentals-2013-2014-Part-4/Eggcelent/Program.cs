using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int width = 3 * n - 1;
        int area = 3 * n + 1;
        int size = n - 1;
        int counter = n - 1;
        int counter2 = n + size;
        int counter3 = 1;
        int counter4 = width;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < area; j++)
            {
                if ((n + 1 <= j && j <= area - n - 2) && (i == 0 || i == height - 1))
                {
                    Console.Write('*');
                }
                else if (j == counter && i != 0)
                {
                    Console.Write('*');
                    counter -= 2;
                }
                else if (j == counter2 && i != 0)
                {
                    Console.Write('*');
                }
                else if (i > n / 2 && i < height - 1 && counter3 == j)
                {
                    Console.Write('*');
                }
                else if (i > n / 2 && i < height - 1 && counter4 == j)
                {
                    Console.Write('*');
                }
                else if (i == height / 2 - 1 && j >= 2 && j <= width - 1)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write('@');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                else if (i == height / 2 && j >= 2 && j <= width - 1)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write('.');
                    }
                    else
                    {
                        Console.Write('@');
                    }
                }
                else
                {
                    Console.Write(".");
                }
            }
            if (i >= height - n / 2 - 1)
            {
                counter3 += 2;
                counter4 -= 2;
            }
            counter2 += 2;
            Console.WriteLine();
        }
    }
}

