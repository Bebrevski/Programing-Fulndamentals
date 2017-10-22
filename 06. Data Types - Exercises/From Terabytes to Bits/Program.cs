using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputTB = double.Parse(Console.ReadLine());

            decimal outputBits = (decimal)((Math.Pow(1024, 4)*8)*inputTB);

            Console.WriteLine((ulong)outputBits);
        }
    }
}
