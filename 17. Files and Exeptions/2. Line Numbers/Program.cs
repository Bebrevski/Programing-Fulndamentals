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
            string[] input = File.ReadAllLines("../../input.txt");

            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                output += (i + 1) + ". " + input[i] + Environment.NewLine;
            }

            File.WriteAllText(@"D:\SoftUni\17. FILES AND EXCEPTIONS\2. Line Numbers\output.txt", output);
        }
    }
}
