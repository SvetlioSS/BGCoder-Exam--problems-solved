using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int count = 0;
        int totalSum = 0;
        for (int i = 0; i < text.Length; i += 2)
        {
            if (char.IsDigit(text, i))
            {
                count++;
                totalSum += Convert.ToInt32(text[i].ToString());
            }
        }
        Console.WriteLine(count + " " + totalSum);
    }
}

