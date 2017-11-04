using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int daysInMOnth = DateTime.DaysInMonth(date.Year, date.Month);
                long capsules = long.Parse(Console.ReadLine());

                decimal currentPrice = (daysInMOnth * (decimal)capsules) * pricePerCapsule;

                Console.WriteLine("The price for the coffee is: ${0:f2}",currentPrice);

                sum += currentPrice;
            }

            Console.WriteLine("Total: ${0:f2}",sum);
        }
    }
}
