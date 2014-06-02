using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int area = 250;
        double totalSum = 0;
        for (int i = 0; i < 11; i++)
        {
            int number = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 0: totalSum += number * 0.5; break;
                case 1: area -= number; break;
                case 2: totalSum += number * 0.4; break;
                case 3: area -= number; break;
                case 4: totalSum += number * 0.25; break;
                case 5: area -= number; break;
                case 6: totalSum += number * 0.6; break;
                case 7: area -= number; break;
                case 8: totalSum += number * 0.3; break;
                case 9: area -= number; break;
                case 10: totalSum += number * 0.4; break;
            }
        }
        Console.WriteLine("Total costs: {0:0.00}", totalSum);
        if (area > 0)
        {
            Console.WriteLine("Beans area: {0}", area);
        }
        else if (area == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (area < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

