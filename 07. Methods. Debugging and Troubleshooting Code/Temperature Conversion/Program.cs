using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = GetConvertedDegrees(fahrenheit);

            Console.WriteLine("{0:f2}", celsius);
        }

        private static double GetConvertedDegrees(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
    }
}
