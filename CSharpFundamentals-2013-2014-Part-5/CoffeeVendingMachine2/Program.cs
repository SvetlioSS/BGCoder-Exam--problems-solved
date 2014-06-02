using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        double sum = n1 * 0.05 + n2 * 0.10 + n3 * 0.20 + n4 * 0.50 + n5 * 1;
        double a = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        if (p == a)
        {
            Console.WriteLine("Yes {0:0.00}", sum);
        }
        else if (p > a)
        {
            Console.WriteLine("More {0:0.00}", (p - a));
        }
        else if (p < a)
        {
            if (sum >= a - p)
            {
                Console.WriteLine("Yes {0:0.00}", (sum - (a - p)));
            }
            else
            {
                Console.WriteLine("No {0:0.00}", (a - p - sum));
            }
        }
    }
}

