using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._ectangle_Position
{
    class Rectabgle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectabgle> record = new List<Rectabgle>();
            for (int i = 0; i < 2; i++)
            {
                int[] input = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToArray();

                Rectabgle current = new Rectabgle()
                {
                    Left = input[0],
                    Top = input[1],
                    Width = input[2],
                    Height = input[3]
                };

                record.Add(current);
            }

            string output = GetPOsitionOfRectangle(record);

            Console.WriteLine(output);
        }

        private static string GetPOsitionOfRectangle(List<Rectabgle> record)
        {
            if (record[0].Left >= record[1].Left &&
                record[0].Top <= record[1].Top &&
                record[0].Width <= record[1].Width &&
                record[0].Height <= record[1].Height)
            {
                return "Inside";
            }
            else
            {
                return "Not inside";
            }
        }
    }
}
