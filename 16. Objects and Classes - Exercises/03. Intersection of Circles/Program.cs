using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Circle> record = new List<Circle>();
            for (int i = 0; i < 2; i++)
            {
                double[] input = Console.ReadLine()
                            .Split()
                            .Select(double.Parse)
                            .ToArray();

                Circle current = new Circle()
                {
                    X = input[0],
                    Y = input[1],
                    Radius = input[2]
                };

                record.Add(current);
            }

            string output = IsIntersect(record);

            Console.WriteLine(output);
        }

        private static string IsIntersect(List<Circle> record)
        {
            double distanceBetweenCenters = Math.Sqrt(
                Math.Pow(record[0].X - record[1].X, 2) +
                Math.Pow(record[1].Y - record[1].Y, 2)
                );

            if (record[0].Radius + record[1].Radius >= distanceBetweenCenters)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
