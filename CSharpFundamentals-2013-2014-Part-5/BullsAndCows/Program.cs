using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string secretNumber = Console.ReadLine();
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if ((b == 3 && c > 0) || (b + c > 4))
        {
            Console.WriteLine("No");
        }
        else if ((secretNumber == "1111" || secretNumber == "2222" || secretNumber == "3333" || secretNumber == "4444" ||
                 secretNumber == "5555" || secretNumber == "6666" || secretNumber == "7777" || secretNumber == "8888" ||
                 secretNumber == "9999") && c > 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int h = 1; h <= 9; h++)
                        {
                            string number = i.ToString() + j.ToString() + k.ToString() + h.ToString();
                            string secretNumberCopy = String.Copy(secretNumber);
                            int bulls = 0;
                            int cows = 0;
                            bool[] bullsChecked = new bool[4];
                            bullsChecked[0] = false;
                            bullsChecked[1] = false;
                            bullsChecked[2] = false;
                            bullsChecked[3] = false;
                            char[] usedDigits = new char[10];
                            for (int digit = 0; digit < 4; digit++)
                            {
                                if (number[digit] == secretNumberCopy[digit])
                                {
                                    bulls++;
                                    bullsChecked[digit] = true;
                                }
                            }
                            for (int asd = 3; asd >= 0; asd--)
                            {
                                if (bullsChecked[asd] == true)
                                {
                                    secretNumberCopy = secretNumberCopy.Remove(asd, 1);
                                    number = number.Remove(asd, 1);
                                }
                            }
                            for (int digit = 0; digit < secretNumberCopy.Length; digit++)
                            {
                                bool someBool2 = secretNumberCopy.Contains(number[digit]);
                                if (someBool2 == true && Array.IndexOf(usedDigits, number[digit]) == -1)
                                {
                                    usedDigits[Convert.ToInt32(number[digit].ToString())] = number[digit];
                                    cows++;
                                }
                            }
                            if (bulls == b && cows == c)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, k, h);
                            }
                        }
                    }
                }
            }
        }
    }
}

