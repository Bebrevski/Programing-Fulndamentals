﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\b[A-Z][a-z]{1,}\b \b[A-Z][a-z]{1,}\b");

            if (pattern.IsMatch(input))
            {
                MatchCollection matches = pattern.Matches(input);

                foreach (Match name in matches)
                {
                    Console.Write(name.Value + " ");
                }
                Console.WriteLine();
            }
        }
    }
}