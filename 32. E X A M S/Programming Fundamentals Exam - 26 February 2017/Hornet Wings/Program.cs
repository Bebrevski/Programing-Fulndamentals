using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            decimal flyingDistance = (wingFlaps / 1000) * (decimal)distance;

            long restingTime = (wingFlaps / endurance) * 5L;

            //да се внимава с типовете данни. 
            //При ползване на флоат трбва другите числа да се кастнат
            long totalTime = (wingFlaps / 100) + restingTime;

            Console.WriteLine("{0:f2} m.", flyingDistance);
            Console.WriteLine("{0} s.", totalTime);
        }
    }
}
