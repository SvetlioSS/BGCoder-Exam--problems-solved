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
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3;
        int sails = (height * 2) / 3;
        int boatBase = height / 3;
        int counter = n;
        int counter2 = 1;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (j == n || i == n || (i != 0 && counter == j) || 
                    (i != 0 && j == width - counter - 1) || (i > n && j == counter2) ||
                    (i > n && j == width - counter2 - 1) || (i == height - 1 && j >= boatBase && j < width - boatBase))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            counter--;
            if (i > n )
            {
                counter2++;
            }
            Console.WriteLine();
        }
    }
}
