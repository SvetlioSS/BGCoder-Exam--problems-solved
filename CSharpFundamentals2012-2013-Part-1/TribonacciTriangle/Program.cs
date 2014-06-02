using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1 = long.Parse(Console.ReadLine());
            long n2 = long.Parse(Console.ReadLine());
            long n3 = long.Parse(Console.ReadLine());
            long L = long.Parse(Console.ReadLine());
            long factoriel = 1;
            for (int i = 1; i <= L; i++)
			{
			    factoriel += i;
			}
            long[] numbers = new long[factoriel];
            numbers[0] = n1;
            numbers[1] = n2;
            numbers[2] = n3;
            for (int i = 3; i < factoriel; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
            }
            int counter = 0;
            for (int i = 0; i < L; i++)
            {

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(numbers[counter]);
                    if (k != i)
                    {
                        Console.Write(" ");
                    }
                    counter++;
                }
                Console.WriteLine();
            }

        }
    }
}
