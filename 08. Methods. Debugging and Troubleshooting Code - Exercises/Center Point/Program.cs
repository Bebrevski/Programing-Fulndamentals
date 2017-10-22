using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double[] record = GetClosestPoint(x1, x2, y1, y2);

            Console.WriteLine("({0}, {1})", record[0], record[1]);
        }

        private static double[] GetClosestPoint(double x1, double x2, double y1, double y2)
        {
            double[] points = new double[2];

            double diagonal1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double diagonal2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (diagonal1 <= diagonal2)
            {
                points[0] = x1;
                points[1] = y1;
            }
            else
            {
                points[0] = x2;
                points[1] = y2;
            }
            return points;
        }
    }
}
