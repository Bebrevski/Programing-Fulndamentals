using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Star__Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            if (input[0].ToLower().Equals("end"))
            {
                Console.WriteLine("0.00");
                return;
            }

            double result = 0;
            foreach (string str in input)
            {
                char firstLetter = str[0];
                long number = long.Parse(str.Substring(1, str.Length - 2));
                char lastLetter = str[str.Length - 1];

                double leftCharManipulation = 0;
                double rightCharManipulation = 0;

                if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    leftCharManipulation = (double)number / (firstLetter - 64);
                }
                else if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    leftCharManipulation = (double)number * (firstLetter - 96);
                }

                if (lastLetter >= 'A' && lastLetter <= 'Z')
                {
                    rightCharManipulation = leftCharManipulation - (lastLetter - 64);
                }
                else if (lastLetter >= 'a' && lastLetter <= 'z')
                {
                    rightCharManipulation = leftCharManipulation + (lastLetter - 96);
                }

                result += rightCharManipulation;
            }

            Console.WriteLine("{0:f2}", result);

        }
    }
}
