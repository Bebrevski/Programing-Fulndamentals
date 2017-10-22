using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i].Equals(input[i + 1]))
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
