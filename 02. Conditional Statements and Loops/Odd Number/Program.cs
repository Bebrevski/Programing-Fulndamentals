using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            do
            {
                n = int.Parse(Console.ReadLine());
                if (n < 0 && n % 2 != 0)
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(n)); return;
                }
                else if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
            } while (n % 2 == 0);
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
