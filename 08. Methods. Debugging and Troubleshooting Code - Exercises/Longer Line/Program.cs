using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstLineLenght = GetLineLength(x1, y1, x2, y2);

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double secondLineLenght = GetLineLength(x3, y3, x4, y4);

            double[] record = new double[4];

            if (firstLineLenght >= secondLineLenght)
            {
                record = GetClosestPoint(x1, x2, y1, y2);
            }
            else
            {
                record = GetClosestPoint(x3, x4, y3, y4);
            }

            Console.WriteLine("({0}, {1})({2}, {3})"
                , record[0]
                , record[1]
                , record[2]
                , record[3]);
        }

        private static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double xlenght = x1 - x2;
            double yLenght = y1 - y2;

            double lineLength = Math.Sqrt(xlenght * xlenght + yLenght * yLenght);

            return lineLength;
        }

        private static double[] GetClosestPoint(double x1, double x2, double y1, double y2)
        {
            double[] points = new double[4];

            double diagonal1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double diagonal2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (diagonal1 <= diagonal2)
            {
                points[0] = x1;
                points[1] = y1;
                points[2] = x2;
                points[3] = y2;
            }
            else
            {
                points[0] = x2;
                points[1] = y2;
                points[2] = x1;
                points[3] = y1;
            }
            return points;
        }
    }
}
