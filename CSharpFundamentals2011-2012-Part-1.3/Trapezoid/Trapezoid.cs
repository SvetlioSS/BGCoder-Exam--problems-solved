using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('.', n));
        Console.Write(new string('*', n));
        Console.WriteLine();
        int counterLeft = n - 1;
        int counterMidd = n - 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', counterLeft));
            Console.Write('*');
            Console.Write(new string('.', counterMidd));
            Console.Write('*');
            counterLeft--;
            counterMidd++;
            Console.WriteLine();
        }
        Console.Write(new string('*', 2 * n));
        Console.WriteLine();
    }
}

