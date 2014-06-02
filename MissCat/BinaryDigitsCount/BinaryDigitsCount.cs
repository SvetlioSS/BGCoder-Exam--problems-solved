using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            char bit = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] bits = new int[n];
            for (int i = 0; i < n; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                string nums = Convert.ToString(number, 2);
                int counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == bit)
                    {
                        counter++;
                    }
                }
                bits[i] = counter;
            }
            foreach (var item in bits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
