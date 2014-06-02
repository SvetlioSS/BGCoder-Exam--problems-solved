using System;

class MathExpression
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        int mod = (int)m % 180;
        double expression = (Math.Pow(n, 2) + 1 / (m * p) + 1337) / (n - 128.523123123 * p) + Math.Sin(mod);
        Console.WriteLine("{0:0.000000}",expression);
    }
}

