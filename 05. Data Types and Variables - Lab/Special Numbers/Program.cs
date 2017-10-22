using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            bool isSpecial = false;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                while (!num.Equals(0))
                {
                    sum += num % 10;

                    num /= 10;
                }
                if (sum.Equals(5) || sum.Equals(7) || sum.Equals(11))
                {
                    isSpecial = true;
                }

                Console.WriteLine("{0} -> {1}",i,isSpecial);

                isSpecial = false;
            }
        }
    }
}
