using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime date2 = DateTime.ParseExact(date, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(date2.DayOfWeek);
        }
    }
}
