using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = x / 2 + 1;
            int width = 2 * x + 2 * z - 3;
            int height = x * 3 - 2;
            int counterForZ = z - 1;
            int positionX = z;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == counterForZ || j == width - counterForZ - 1)
                    {
                        Console.Write('*');
                    }
                    else if ((j == positionX || j == width - positionX - 1) && i != 0)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                if (i > 0 && i < height - x)
                {
                    positionX++;
                }
                else if (i > 0)
                {
                    positionX--;
                }
                counterForZ--;
            }
        }
    }
}
