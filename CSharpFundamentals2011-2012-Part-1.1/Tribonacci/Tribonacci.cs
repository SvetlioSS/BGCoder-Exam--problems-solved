using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        BigInteger[] allNums = new BigInteger[number];
        allNums[0] = n1;
        allNums[1] = n2;
        allNums[2] = n3;
        for (long i = 3; i < number; i++)
        {
            allNums[i] = allNums[i - 1] + allNums[i - 2] + allNums[i - 3];
        }
        Console.WriteLine(allNums[number - 1]);
    }
}

