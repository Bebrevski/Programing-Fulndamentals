using System;
using System.Globalization;

namespace _1._Day_of_Week
{
    class DayOfWeek
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime input = DateTime.ParseExact(
                Console.ReadLine()
                , "d-M-yyyy"
                , CultureInfo.InvariantCulture);

            DayOfWeek current = new DayOfWeek()
            {
                Day = input.Day,
                Month = input.Month,
                Year = input.Year
            };

            DateTime output = new DateTime(current.Year,current.Month,current.Day);

            Console.WriteLine(output.DayOfWeek);
        }
    }
}
