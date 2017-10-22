using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            array = Revercearray(array);

            Console.WriteLine(string.Join(" ", array));
        }

        private static string[] Revercearray(string[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            return array;
        }
    }
}
