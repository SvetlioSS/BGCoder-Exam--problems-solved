using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int height = int.Parse(Console.ReadLine());
        int width = 2 * height;
        int counter = width / 2 - 1;
        int counter2 = width / 2;
        int[] numbers = { 1, 3, 6, 10, 15, 21, 28, 36 };
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (j == counter)
                {
                    Console.Write('/');
                }
                else if (j == counter2)
                {
                    Console.Write('\\');
                }
                else if ((Array.IndexOf(numbers, i) != -1) && counter < j && j < counter2)
                {
                    Console.Write('-');
                }
                else
                {
                    Console.Write('.');
                }
            }
            counter2++;
            counter--;
            Console.WriteLine();
        }
    }
}

