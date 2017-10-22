using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 256)
            {
                double Remainder = input % 256;
                byte overflowtimes = (byte)(input / 256);
                Console.WriteLine("{0}", Remainder);
                Console.WriteLine("Overflowed {0} times", overflowtimes);
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
