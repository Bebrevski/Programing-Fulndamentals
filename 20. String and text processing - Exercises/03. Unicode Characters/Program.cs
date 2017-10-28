using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //IEnumerable<string> chars = input.Select(c => (int)c).Select(c => @"\u" + string.Format("{0:x4}", c));

            //Console.WriteLine(string.Join(string.Empty, chars));

            StringBuilder result = new StringBuilder();

            foreach (char lett in input)
            {
                result.AppendFormat(@"\u{0:x4}", (int)lett);
            }

            Console.WriteLine(result);
        }
    }
}
