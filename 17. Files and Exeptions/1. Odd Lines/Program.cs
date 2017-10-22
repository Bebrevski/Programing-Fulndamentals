using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    output += input[i] + Environment.NewLine;
                }
            }

            File.WriteAllText(@"D:\SoftUni\17. FILES AND EXCEPTIONS\1. Odd Lines\output.txt", output);
        }
    }
}
