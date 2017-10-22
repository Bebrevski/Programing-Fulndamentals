using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = (char)input[i] - 'a';
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1}"
                    , input[i]
                    , arr[i]);
            }
        }
    }
}
