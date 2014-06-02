using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        long sumOddDigits = 0;
        long sumEvenDigits = 0;
        string direction = "";
        for (int i = 0; i < n.Length; i++)
        {
            if (char.IsDigit(n[i]))
            {
                if (Convert.ToInt64(n[i].ToString()) % 2 == 0)
                {
                    sumEvenDigits += Convert.ToInt64(n[i].ToString());
                }
                else
                {
                    sumOddDigits += Convert.ToInt64(n[i].ToString());
                }
            }
        }
        if (sumEvenDigits > sumOddDigits)
        {
            direction = "right";
            Console.WriteLine(direction + " " + sumEvenDigits);
        }
        else if (sumEvenDigits < sumOddDigits)
        {
            direction = "left";
            Console.WriteLine(direction + " " + sumOddDigits);
        }
        else if (sumEvenDigits == sumOddDigits)
        {
            direction = "straight";
            Console.WriteLine(direction + " " + sumEvenDigits);
        }
    }
}

