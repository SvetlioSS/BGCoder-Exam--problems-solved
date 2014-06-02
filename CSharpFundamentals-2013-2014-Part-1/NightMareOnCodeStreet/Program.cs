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
        int sum = 0;
        int count = 0;
        for (int i = 1; i < text.Length; i += 2)
        {
            if (char.IsDigit(text[i]))
            {
                sum += Convert.ToInt32(text[i].ToString());
                count++;
            }
        }
        Console.Write(count + " ");
        Console.WriteLine(sum);
    }
}

