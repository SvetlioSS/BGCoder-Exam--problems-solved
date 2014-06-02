using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        public static int CalculateSum(string number)
        {
            int totalSum1 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if ((number[i] == '-') || (number[i] == '.'))
                {
                    continue;
                }
                else
                {
                    totalSum1 += Convert.ToInt32(number[i].ToString());
                }
            }
            if (totalSum1 <= 9)
            {
                return totalSum1;
            }
            else
            {
                return CalculateSum(totalSum1.ToString());
            }
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string totalSum = CalculateSum(number).ToString();
            Console.WriteLine(totalSum);
        }
    }
}
