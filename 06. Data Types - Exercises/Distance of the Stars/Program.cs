using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal constant = 9450000000000m;

            decimal earthToNearestStar = constant * 4.22m;
            decimal centerToMIlkyWay = constant * 26000m;
            decimal diameterOfMilkyWay = constant * 100000m;
            decimal earthToObservable = constant * 46500000000m;

            Console.WriteLine("{0:e2}",earthToNearestStar);
            Console.WriteLine("{0:e2}",centerToMIlkyWay);
            Console.WriteLine("{0:e2}",diameterOfMilkyWay);
            Console.WriteLine("{0:e2}",earthToObservable);
        }
    }
}
