using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = n - 1;
            for (int i = 0; i < n*2 - 1; i++)
            {
                if (i < n)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == i)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j == counter)
                        {
                            Console.Write('*');
                            counter--;
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
