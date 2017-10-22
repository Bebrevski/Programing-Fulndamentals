using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var sumMinutes = hours * 60 + minutes + 30;

            var finalHours = sumMinutes / 60;
            var finalminutes = sumMinutes % 60;
            if (finalHours >= 24)
            {
                Console.WriteLine("{0}:{1:00}", finalHours - 24, finalminutes);
            }
            else
            {
                Console.WriteLine("{0}:{1:00}", finalHours, finalminutes);
            }
        }
    }
}
