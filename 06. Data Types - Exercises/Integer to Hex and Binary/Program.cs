using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string hexDec = string.Format("{0:x}", n).ToUpper();
            Console.WriteLine(hexDec);
            string binary = Convert.ToString(n, 2);
            Console.WriteLine(binary);
        }
    }
}
