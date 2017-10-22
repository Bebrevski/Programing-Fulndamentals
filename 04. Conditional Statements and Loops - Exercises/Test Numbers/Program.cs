using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    counter++;
                    sum += i * j * 3;
                    if (sum >= endNumber)
                    {
                        Console.WriteLine("{0} combinations",counter);
                        Console.WriteLine("Sum: {0} >= {1}",sum,endNumber);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations",counter);
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
