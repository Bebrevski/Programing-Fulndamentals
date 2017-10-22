using System;
using System.Globalization;
using System.Linq;

namespace _01._Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(
                Console.ReadLine(),
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            DateTime secondDate = DateTime.ParseExact(
                Console.ReadLine(),
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            DateTime[] record = new DateTime[]
            {
                new DateTime(firstDate.Year,01,01),
                new DateTime(firstDate.Year,03,03),
                new DateTime(firstDate.Year,05,01),
                new DateTime(firstDate.Year,05,06),
                new DateTime(firstDate.Year,05,24),
                new DateTime(firstDate.Year,09,06),
                new DateTime(firstDate.Year,09,22),
                new DateTime(firstDate.Year,11,01),
                new DateTime(firstDate.Year,12,24),
                new DateTime(firstDate.Year,12,25),
                new DateTime(firstDate.Year,12,26)
            };

            int count = 0;

            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                if (!IsDayOff(i, record))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private static bool IsDayOff(DateTime i, DateTime[] record)
        {
            if (record.Where(x => x.Month.Equals(i.Month)).Select(x=>x.Day).Contains(i.Day)||
                (i.DayOfWeek.Equals(DayOfWeek.Saturday)|| i.DayOfWeek.Equals(DayOfWeek.Sunday)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
