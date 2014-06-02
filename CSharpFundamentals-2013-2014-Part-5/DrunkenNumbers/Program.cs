using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        ulong mitkoTotalBeers = 0;
        ulong vladkoTotalBeers = 0;
        for (int i = 0; i < n; i++)
        {
            int numb = int.Parse(Console.ReadLine());
            string number = (Math.Abs(numb)).ToString();
            if (number.Length % 2 == 0)
            {
                string num = number;
                for (int j = 0; j < num.Length / 2; j++)
                {
                    mitkoTotalBeers += Convert.ToUInt64(num[j].ToString());
                }
                for (int k = num.Length / 2; k < num.Length; k++)
                {
                    vladkoTotalBeers += Convert.ToUInt64(num[k].ToString());
                }
            }
            else
            {
                string num = number;
                for (int j = 0; j <= (num.Length - 1) / 2; j++)
                {
                    mitkoTotalBeers += Convert.ToUInt64(num[j].ToString());
                }
                for (int k = (num.Length - 1) / 2; k < num.Length; k++)
                {
                    vladkoTotalBeers += Convert.ToUInt64(num[k].ToString());
                }
            }
        }
        if (mitkoTotalBeers > vladkoTotalBeers)
        {
            Console.WriteLine("M " + (mitkoTotalBeers - vladkoTotalBeers));
        }
        else if (mitkoTotalBeers < vladkoTotalBeers)
        {
            Console.WriteLine("V " + (vladkoTotalBeers - mitkoTotalBeers));
        }
        else if (mitkoTotalBeers == vladkoTotalBeers)
        {
            Console.WriteLine("No " + (vladkoTotalBeers + mitkoTotalBeers));
        }
    }
}

