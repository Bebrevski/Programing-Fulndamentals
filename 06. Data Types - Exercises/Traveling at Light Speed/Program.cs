using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmLightYear = 9450000000000;
            decimal lightSpeed = 300000;
            decimal ligthyears = decimal.Parse(Console.ReadLine());

            decimal sumSeconds = (ligthyears * kmLightYear) / lightSpeed;
            decimal sumMinutes = sumSeconds / 60;
            sumSeconds %= 60;
            decimal sumHours = sumMinutes / 60;
            sumMinutes %= 60;
            decimal sumDays = sumHours / 24;
            sumHours %= 24;
            decimal sumWeeks = sumDays / 7;
            sumDays %= 7;

            Console.WriteLine("{0} weeks", Math.Floor(sumWeeks));
            Console.WriteLine("{0} days", Math.Floor(sumDays));
            Console.WriteLine("{0} hours", Math.Floor(sumHours));
            Console.WriteLine("{0} minutes", Math.Floor(sumMinutes));
            Console.WriteLine("{0} seconds", Math.Floor(sumSeconds));


        }
    }
}
