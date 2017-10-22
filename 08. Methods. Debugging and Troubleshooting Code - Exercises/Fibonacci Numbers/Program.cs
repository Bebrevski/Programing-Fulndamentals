using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int fibonacci = GetFibonacci(num);

            Console.WriteLine(fibonacci);
        }

        private static int GetFibonacci(int num)
        {
            int f0 = 1;
            int f1 = 1;
            int fibonacci = 0;

            if (num < 2)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i < num; i++)
                {
                    fibonacci = f0 + f1;
                    f0 = f1;
                    f1 = fibonacci;
                }
                return fibonacci;
            }
        }
    }
}
