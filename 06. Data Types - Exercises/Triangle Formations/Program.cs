using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }

            bool AB = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
            bool BC = Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2);
            bool CA = Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2);
            bool ABC = a == b && b == c;

            if (AB == true) Console.WriteLine("Triangle is valid.\r\nTriangle has a right angle between sides a and b");

            else if (BC == true) Console.WriteLine("Triangle is valid.\r\nTriangle has a right angle between sides b and c");

            else if (CA == true) Console.WriteLine("Triangle is valid.\r\nTriangle has a right angle between sides a and c");

            else if (ABC == true) Console.WriteLine("Triangle is valid.\r\nTriangle has no right angles");

            else if (AB == false || BC == false || CA == false) Console.WriteLine("Invalid Triangle.");
        }
    }
}
