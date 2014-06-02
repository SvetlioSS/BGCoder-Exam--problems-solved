using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 0; i < n - 1; i++)
            {
                string filler = new string('.', n - 2 - i);
                Console.Write(filler);
                for (int j = 0; j < counter; j++)
                {
                    Console.Write("*");
                }
                Console.Write(filler);
                counter += 2;
                Console.WriteLine();
            }
            string filler1 = new string('.', n - 2);
            Console.Write(filler1 + "*" + filler1);
        }
    }
}
