using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var OddNumbers = 1;
            var sumOddNumbers = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(OddNumbers);
                OddNumbers += 2;
                if (i == n) break;
                sumOddNumbers += OddNumbers;
            }

            Console.WriteLine("Sum: {0}",sumOddNumbers);
        }
    }
}
