using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int hexadesimal = Convert.ToInt32(input, 16);

            Console.WriteLine(hexadesimal);
        }
    }
}
