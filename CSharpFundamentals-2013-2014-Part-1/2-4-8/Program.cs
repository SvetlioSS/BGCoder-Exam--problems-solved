using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal r = 0;
        if (b == 2)
        {
            r = a % c;            
        }
        if (b == 4)
        {
            r = a + c;
        }
        if (b == 8)
        {
            r = a * c;
        }
        if (r % 4 == 0)
        {
            Console.WriteLine(r / 4);
        }
        else
        {
            Console.WriteLine(r % 4);
        }
        Console.WriteLine(r);
    }
}

