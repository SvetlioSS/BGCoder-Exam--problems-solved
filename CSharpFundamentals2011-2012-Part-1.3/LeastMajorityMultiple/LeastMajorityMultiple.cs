using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        long lcm = 0;
        for (long i = 1; i < 10000000000; i++)
        {
            if (i % a == 0)
            {
                lcm++;
            }
            if (i % b == 0)
            {
                lcm++;
            }
            if (i % c == 0)
            {
                lcm++;
            }
            if (i % d == 0)
            {
                lcm++;
            }
            if (i % e == 0)
            {
                lcm++;
            }
            if (lcm >= 3)
            {
                Console.WriteLine(i);
                break;
            }
            else
            {
                lcm = 0;
            }
        }
    }
}

