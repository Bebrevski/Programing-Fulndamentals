using System;
using System.Linq;

namespace _4._Distance_between_Points
{
    class Point
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }

        public static double CalcDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstPoint = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondPoint = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Point points = new Point()
            {
                x1 = firstPoint[0],
                y1 = firstPoint[1],
                x2 = secondPoint[0],
                y2 = secondPoint[1]
            };

            double distance = Point.CalcDistance(points.x1, points.y1, points.x2, points.y2);

            Console.WriteLine($"{distance:f3}");
        }
    }
}
