using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nightCount = int.Parse(Console.ReadLine());

            var Studio = 0.0;
            var Double = 0.0;
            var Suite = 0.0;

            if (month == "may" || month == "october")
            {
                Studio = 50 * nightCount;
                Double = 65 * nightCount;
                Suite = 75 * nightCount;
                if (nightCount > 7)
                {
                    Studio *= 0.95;
                }
                if (month == "october" && nightCount > 7)
                {
                    Studio -= (50*0.95);
                    // !!!!!!!!!!!!!!!!!
                }

            }
            else if (month == "june" || month == "september")
            {
                Studio = 60 * nightCount;
                Double = 72 * nightCount;
                Suite = 82 * nightCount;
                if (nightCount > 14)
                {
                    Double *= 0.9;
                }
                if (month == "september" && nightCount > 7)
                {
                    Studio -= 60;
                }
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                Studio = 68 * nightCount;
                Double = 77 * nightCount;
                Suite = 89 * nightCount;
                if (nightCount > 14)
                {
                    Suite *= 0.85;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.", Studio);
            Console.WriteLine("Double: {0:f2} lv.", Double);
            Console.WriteLine("Suite: {0:f2} lv.", Suite);
        }
    }
}
