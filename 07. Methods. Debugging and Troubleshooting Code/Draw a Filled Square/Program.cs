using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintDashes(number * 2, '-');

            PrintMiddleLines(number * 2);

            PrintDashes(number * 2, '-');
        }
        static void PrintDashes(int counter, char symbol)
        {
            Console.WriteLine(new string(symbol, counter));
        }
        static void PrintMiddleLines(int number)
        {
            for (int i = 0; i < number / 2 - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < (number - 2) / 2; j++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
