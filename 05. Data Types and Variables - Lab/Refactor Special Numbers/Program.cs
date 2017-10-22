using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNum = 0;
            bool isSpecial = false;

            for (int index = 1; index <= n; index++)
            {
                currentNum = index;
                while (index > 0)
                {
                    sum += index % 10;
                    index = index / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNum, isSpecial);
                sum = 0;
                index = currentNum;
            }

        }
    }
}
