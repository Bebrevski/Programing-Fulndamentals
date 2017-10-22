using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]<0)
                {
                    input.RemoveAt(i);
                    i--;
                }
            }

            //input.RemoveAll(x => x < 0);
            input.Reverse();

            if (input.Count.Equals(0))
            {
                Console.WriteLine("empty");
                return;
            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
