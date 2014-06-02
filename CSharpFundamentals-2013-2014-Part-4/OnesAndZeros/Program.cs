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
        for (int i = 0; i < 5; i++)
        {
            for (int j = 15; j >= 0; j--)
            {
                int digit = (n >> j) & 1;
                if (digit == 1)
                {
                    if (i == 0)
                    {
                        Console.Write(".#.");
                    }
                    else if (i == 1)
                    {
                        Console.Write("##.");
                    }
                    else if (i == 2 || i == 3)
                    {
                        Console.Write(".#.");
                    }
                    else if (i == 4)
                    {
                        Console.Write("###");
                    }
                }
                else
                {
                    if (i == 0 || i == 4)
                    {
                        Console.Write("###");
                    }
                    else if (i == 1 || i == 2 || i == 3)
                    {
                        Console.Write("#.#");
                    }
                }
                if (j != 0)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

