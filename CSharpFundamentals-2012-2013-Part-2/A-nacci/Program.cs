using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            char fstChar = char.Parse(Console.ReadLine());
            int firstChar = Convert.ToInt32(fstChar);
            char sndChar = char.Parse(Console.ReadLine());
            int secondChar = Convert.ToInt32(sndChar);
            int lines = int.Parse(Console.ReadLine());
            int thirdChar;
            char[] elements = new char[lines * 2 - 1];
            elements[0] = fstChar;
            if (lines == 1)
            {
                Console.WriteLine(fstChar);
            }
            else
            {
                elements[1] = sndChar;
                for (int i = 2; lines * 2 - 1 > i; i++)
                {
                    thirdChar = firstChar + secondChar - 64;
                    if (thirdChar > 90)
                    {
                        thirdChar = thirdChar - 90 + 64;
                    }
                    elements[i] = Convert.ToChar(thirdChar);
                    firstChar = secondChar;
                    secondChar = thirdChar;
                }
                int counter = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(elements[i]);
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write(elements[i] + new string(' ', counter));
                        counter++;
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write(elements[i]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
