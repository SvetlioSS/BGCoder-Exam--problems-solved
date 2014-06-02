using System;
using System.Collections.Generic;
using System.Linq;

class OddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var numbers = new string[n];
        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            numbers[i] = number.ToString();
        }
        var groups = numbers.GroupBy(x => x);
        foreach (var group in groups)
        {
            if (group.Count() % 2 != 0)
            {
                Console.WriteLine(group.Key);
                break;
            }
        }
    }
}

