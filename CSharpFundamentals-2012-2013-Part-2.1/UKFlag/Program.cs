using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int counterRight = k - 1;
        int counterLeft = 0;
        int middle = (k - 1) / 2;
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (j == middle)
                {
                    if (i != middle)
                    {
                        Console.Write('|');
                    }
                    else if (i == middle)
                    {
                        Console.Write('*');
                    }
                }
                else if (counterLeft == j)
                {
                    Console.Write('\\');
                }
                else if (counterRight == j)
                {
                    Console.Write('/');
                }
                else
                {
                    if (i == middle)
                    {
                        Console.Write('-');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
            }
            counterLeft++;
            counterRight--;
            Console.WriteLine();
        }
    }
}

