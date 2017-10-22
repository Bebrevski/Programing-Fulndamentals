using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                 Console.WriteLine("{0} -> {1}"
                    , numbers[i]
                    , numbers.FindAll(x => x == numbers[i]).Count());

                 int current = numbers[i];

                 numbers.RemoveAll(x => x == current);
                 i = -1;
            }
        }
    }
}
