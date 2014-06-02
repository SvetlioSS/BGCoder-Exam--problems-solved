using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sheets = new string[11];
            sheets[0] = "A0";
            sheets[1] = "A1";
            sheets[2] = "A2";
            sheets[3] = "A3";
            sheets[4] = "A4";
            sheets[5] = "A5";
            sheets[6] = "A6";
            sheets[7] = "A7";
            sheets[8] = "A8";
            sheets[9] = "A9";
            sheets[10] = "A10";
            int n = int.Parse(Console.ReadLine());
            if ((n >= 1024) && (n > 0))
            {
                n = n - 1024;
                sheets[0] = "";
            }
            if ((n >= 512) && (n > 0))
            {
                n = n - 512;
                sheets[1] = "";
            }
            if ((n >= 256) && (n > 0))
            {
                n = n - 256;
                sheets[2] = "";
            }
            if ((n >= 128) && (n > 0))
            {
                n = n - 128;
                sheets[3] = "";
            }
            if ((n >= 64) && (n > 0))
            {
                n = n - 64;
                sheets[4] = "";
            }
            if ((n >= 32) && (n > 0))
            {
                n = n - 32;
                sheets[5] = "";
            }
            if ((n >= 16) && (n > 0))
            {
                n = n - 16;
                sheets[6] = "";
            }
            if ((n >= 8) && (n > 0))
            {
                n = n - 8;
                sheets[7] = "";
            }
            if ((n >= 4) && (n > 0))
            {
                n = n - 4;
                sheets[8] = "";
            }
            if ((n >= 2) && (n > 0))
            {
                n = n - 2;
                sheets[9] = "";
            }
            if ((n >= 1) && (n > 0))
            {
                n = n - 1;
                sheets[10] = "";
            }
            for (int i = 0; i < sheets.Length; i++)
            {
                if (sheets[i] != "")
                {
                    Console.WriteLine(sheets[i]);
                }
            }
            
        }
    }
}
