using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var countinteger = 0;

            try
            {
                do
                {
                    var number = int.Parse(Console.ReadLine());
                    countinteger++;
                } while (true);
            }
            catch
            {

                Console.WriteLine(countinteger);
            }
        }
    }
}
