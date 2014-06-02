using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                string filler = new string('.', n / 2 - i);
                Console.Write(filler);
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.Write(filler);
                Console.WriteLine();
            }
            //second part
            int counter = 0;
            for (int i = n / 2; i >= 1; i--)
            {
                string filler = new string('.', counter);
                Console.Write(filler);
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }

                }
                Console.Write(filler);
                Console.WriteLine();
                counter++;
            }
        }
    }
}
