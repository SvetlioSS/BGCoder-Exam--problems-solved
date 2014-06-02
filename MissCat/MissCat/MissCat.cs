using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            uint[] cats = new uint[10];
            uint n = uint.Parse(Console.ReadLine());
            for (uint i = 0; i < n; i++)
            {
                uint vote = uint.Parse(Console.ReadLine());
                cats[vote - 1] += 1;
            }
            for (uint i = 0; i < cats.Length; i++)
            {
                if (cats[i] == cats.Max())
                {
                    Console.WriteLine(i+1);
                    break;
                }
            }
        }
    }
}
