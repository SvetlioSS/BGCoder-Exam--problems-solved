using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianSystem
{
    class CartesianSystem
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            bool firstQuadrant = (x > 0) && (y > 0);
            bool secondQuadrant = (x < 0) && (y > 0);
            bool thirdQuadrant = (x < 0) && (y < 0);
            bool forthQuadrant = (x > 0) && (y < 0);
            bool pointOnVectorY = (x == 0) && (y != 0);
            bool pointOnVectorX = (x != 0) && (y == 0);
            bool zeroPoint = (x == 0) && (y == 0);
            if (zeroPoint == true)
            {
                Console.WriteLine(0);
            }
            else if (firstQuadrant == true)
            {
                Console.WriteLine(1);
            }
            else if (secondQuadrant == true)
            {
                Console.WriteLine(2);
            }
            else if (thirdQuadrant == true)
            {
                Console.WriteLine(3);
            }
            else if (forthQuadrant == true)
            {
                Console.WriteLine(4);
            }
            else if (pointOnVectorY == true)
            {
                Console.WriteLine(5);
            }
            else if (pointOnVectorX == true)
            {
                Console.WriteLine(6);
            }
        }
    }
}
