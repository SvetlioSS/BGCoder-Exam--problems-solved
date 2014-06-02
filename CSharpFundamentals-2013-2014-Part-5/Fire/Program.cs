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
        int counter = 0;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j || n / 2 + counter == j)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }
            }
            counter++;
            Console.WriteLine();
        }
        int counter2 = 1;
        for (int i = 0; i < n / 4  ; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j || j == n - counter2)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }
            }
            counter2++;
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', n));
        for (int i = 0; i < n / 2; i++)
        {
            string filler = new string('.', i);
            Console.Write(filler);
            Console.Write(new string('\\', n / 2 - i));
            Console.Write(new string('/', n / 2 - i));
            Console.Write(filler);
            Console.WriteLine();
        }
    }
}

