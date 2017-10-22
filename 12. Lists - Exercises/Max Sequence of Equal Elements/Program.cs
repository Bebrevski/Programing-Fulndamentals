using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int start = 0;
            int counter = 0;
            int max = 0;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i].Equals(sequence[i + 1]))
                {
                    counter++;
                    if (counter > max)
                    {
                        start = i - counter +1;
                        max = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = start; i < start + max + 1; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
