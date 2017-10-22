using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Closest_Two_Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();
            for (int i = 0; i < input; i++)
            {
                int[] currentPoint = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int x = currentPoint[0];
                int y = currentPoint[1];

                Point current = new Point()
                {
                    X = x,
                    Y = y
                };

                points.Add(current);
            }

            Point[] closestPoints = new Point[2];

            double minDistance = GetMinValue(points, closestPoints);


            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({closestPoints[0].X}, {closestPoints[0].Y})");
            Console.WriteLine($"({closestPoints[1].X}, {closestPoints[1].Y})");
        }

        private static double GetMinValue(List<Point> points, Point[] closestPoints)
        {
            double minDistance = double.MaxValue;
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double currentDistance = Math.Sqrt(
                        Math.Pow(points[i].X - points[j].X, 2) +
                        Math.Pow(points[i].Y - points[j].Y, 2)
                        );

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }
            return minDistance;
        }
    }
}
