using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        BigInteger sum = 0;
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        string number2 = new string(charArray);
        for (int i = 0; i < number2.Length; i++)
        {
            if (char.IsDigit(number2[i]) == true && ((i + 1) % 2 != 0))
            {
                BigInteger n = BigInteger.Parse(number2[i].ToString());
                sum += n * (i + 1) * (i + 1);
            }
            else if (char.IsDigit(number2[i]) == true && ((i + 1) % 2 == 0))
            {
                BigInteger n = BigInteger.Parse(number2[i].ToString());
                sum += (n * n) * (i + 1);
            }
        }
        BigInteger lengthOfSequence = sum % 10;
        BigInteger tmp = sum % 26;
        int r = (int)tmp;
        int start = 65 + r;
        if (start > 90) start = 65;
        string alphaSequence = "";
        for (int i = 0; i < lengthOfSequence; i++)
        {
            alphaSequence += Convert.ToChar(start);
            if (start + 1 > 90)
            {
                start = 64;
            }
            start++;
        }
        if (lengthOfSequence == 0)
        {
            Console.WriteLine(sum);
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }
        else
        {
            Console.WriteLine(sum);
            Console.WriteLine(alphaSequence);
        }
    }
}

