using System;
using System.Linq;
using System.Text.RegularExpressions;

class DancingBits
{
    static void Main()
    {

        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string number = "";
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            number += Convert.ToString(num, 2);
        }
        int kSequences = 0;
        int counter = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
            {
                counter++;
            }
            else if (counter == k)
            {
                kSequences++;
            }
            if (number[i] != '1')
            {
                counter = 0;
            }
        }
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '0')
            {
                counter++;
            }
            else if (counter == k)
            {
                kSequences++;
            }
            if (number[i] != '0')
            {
                counter = 0;
            }
        }
        Console.WriteLine(kSequences);
    }
}

