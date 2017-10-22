using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex didimon = new Regex(@"[^a-zA-Z-]+");
            Regex bojomon = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");

            int turn = 1;
            while (didimon.IsMatch(input) || bojomon.IsMatch(input))
            {
                if (turn % 2 != 0)
                {
                    if (!didimon.IsMatch(input))
                    {
                        return;
                    }
                    else
                    {
                        Match didimonMatch = didimon.Match(input);

                        int index = input.IndexOf(didimonMatch.ToString());
                        int indexLenght = didimonMatch.ToString().Length;

                        Console.WriteLine(didimonMatch.ToString());

                        input = input.Remove(0, index + indexLenght);
                    }
                }
                else if (turn % 2 == 0)
                {
                    if (!bojomon.IsMatch(input))
                    {
                        return;
                    }
                    else
                    {
                        Match bojomonMatch = bojomon.Match(input);

                        int index = input.IndexOf(bojomonMatch.ToString());
                        int indexLenght = bojomonMatch.ToString().Length;

                        Console.WriteLine(bojomonMatch.ToString());

                        input = input.Remove(0, index + indexLenght);
                    }
                }

                turn++;
            }
        }
    }
}
