using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte number1 = -100;
            byte number2 = 128;
            short number3 = -3540;
            ushort number4 = 64876;
            uint number5 = 2147483648;
            int number6 = -1141583228;
            decimal number7 = -1223372036854775808m;
            Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}",
                number1,number2,number3,number4,number5,number6,number7);
        }
    }
}
