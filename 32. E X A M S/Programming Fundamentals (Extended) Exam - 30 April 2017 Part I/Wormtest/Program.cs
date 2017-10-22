using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            length *= 100;

            if (length % width == 0 || width == 0)
            {
                Console.WriteLine("{0:f2}", length * width);
            }
            else
            {
                Console.WriteLine("{0:f2}%", (length / width) * 100);
            }
        }
    }
}
