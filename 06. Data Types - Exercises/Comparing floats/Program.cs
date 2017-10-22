using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double diff = Math.Abs(a - b);

            if (diff>=eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
