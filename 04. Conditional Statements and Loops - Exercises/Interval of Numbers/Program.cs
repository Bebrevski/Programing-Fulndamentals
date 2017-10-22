using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            for (int i = Math.Min(firstNumber,secondNumber); i <= Math.Max(firstNumber,secondNumber); i++)
            {
                Console.WriteLine(i);  
            }
        }
    }
}
