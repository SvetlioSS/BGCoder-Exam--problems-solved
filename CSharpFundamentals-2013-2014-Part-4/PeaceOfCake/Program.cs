﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ulong a = ulong.Parse(Console.ReadLine());
        ulong b = ulong.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());
        ulong d = ulong.Parse(Console.ReadLine());
        ulong denominator = b * d;
        a *= d;
        c *= b;
        ulong sum = a + c;
        decimal asd = (a + c) / denominator;
        if (asd >= 1)
        {
            ulong num = (a + c) / denominator;
            Console.WriteLine(num);
            Console.WriteLine("{0}/{1}", sum, denominator);
        }
        else
        {
            decimal num = (Convert.ToDecimal(a) + Convert.ToDecimal(c)) / Convert.ToDecimal(denominator);
            Console.WriteLine("{0:0.0000000000000000000000}", num);
            Console.WriteLine("{0}/{1}", sum, denominator);
        }
    }
}

