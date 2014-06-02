using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime currentDate = new DateTime(year, month, day);
            currentDate = currentDate.AddDays(1);
            Console.WriteLine(currentDate.Day + "." + currentDate.Month + "." + currentDate.Year);
        }
    }
}
