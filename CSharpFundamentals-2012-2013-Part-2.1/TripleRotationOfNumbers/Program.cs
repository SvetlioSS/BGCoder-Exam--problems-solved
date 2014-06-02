using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleRotationOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if (k > 9)
                {
                    int lastDigit = k % 10;
                    k /= 10;
                    string result = lastDigit.ToString() + k.ToString();
                    k = int.Parse(result);
                }
            }
            Console.WriteLine(k);
        }
    }
}
