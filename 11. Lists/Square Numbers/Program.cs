using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> output = new List<int>();

            foreach (int num in numbers)
            {
                if (Math.Sqrt(num).Equals((int)Math.Sqrt(num)))
                {
                    output.Add(num);
                }
            }

            output.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
