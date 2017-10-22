using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Print(i);
            }

            for (int j = number - 1; j > 0; j--)
            {
                Print(j);
            }
        }

        static void Print(int index)
        {
            for (int i = 1; i <= index; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
