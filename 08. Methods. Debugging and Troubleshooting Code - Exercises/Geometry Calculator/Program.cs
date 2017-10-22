using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double result;

            if (figure.Equals("triangle"))
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = GetTriangleArea(side, height);
            }
            else if (figure.Equals("square"))
            {
                double side = double.Parse(Console.ReadLine());

                result = GetSquareArea(side);
            }
            else if (figure.Equals("rectangle"))
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = GetRectangleArea(width, height);
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());

                result = GetCircleArea(radius);
            }

            Console.WriteLine("{0:f2}", result);
        }

        private static double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(2 * radius, 2) / 4;
        }

        private static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        private static double GetSquareArea(double side)
        {
            return side * side;
        }

        private static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
