using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenlandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            if (k == 666)
            {
                k = 1000;
            }
            else
            {
                if (k % 10 == 6)
                {
                    if ((k / 10) % 10 == 6)
                    {
                        k += 30;
                    }
                    if (k % 10 == 6)
                    {
                        k += 4;
                    }
                }
                else
                {
                    k += 1;
                }
            }
            Console.WriteLine(k);
        }
    }
}
