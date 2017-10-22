using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.X
{
    class Program
    {
        static void Main(string[] args)
        {
           // var n = int.Parse(Console.ReadLine());
           // var left = 0;
           // var right = n - 1;
           //
           // for (int i = 0; i < n; i++)
           // {
           //     for (int j = 0; j < n; j++)
           //     {
           //         if (j == left || j == right)
           //         {
           //             Console.Write('x');
           //         }
           //         else
           //         {
           //             Console.Write(' ');
           //         }
           //     }
           //     Console.WriteLine();
           //     left++;
           //     right--;
           // }


            var n = int.Parse(Console.ReadLine());
            
            var sideSpaces = 0;
            var middleSpaces = n - 2;
            
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', sideSpaces), new string(' ', middleSpaces));
                sideSpaces++;
                middleSpaces -= 2;
            }
            
            Console.WriteLine("{0}x", new string(' ', sideSpaces));
            
            for (int i = 1; i <= n / 2; i++)
            {
                sideSpaces--;
                middleSpaces += 2;
                Console.WriteLine("{0}x{1}x{0}", new string(' ', sideSpaces), new string(' ', middleSpaces));
            }
        }
    }
}
