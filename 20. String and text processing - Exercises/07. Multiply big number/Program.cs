using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder number1 = new StringBuilder(Console.ReadLine());
            StringBuilder number2 = new StringBuilder(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            int multilied = 0;
            int remain = 0;
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                for (int j = number2.Length - 1; j >= 0; j--)
                {
//Multiply
                }
            }

            Console.WriteLine(result.ToString().TrimStart('1'));
        }
    }
}
