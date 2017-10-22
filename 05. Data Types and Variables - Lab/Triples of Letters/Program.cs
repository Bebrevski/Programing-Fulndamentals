using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        int first = i + 'a';
                        int second = j + 'a';
                        int third = k + 'a';

                        Console.WriteLine("{0}{1}{2}"
                            , (char)first
                            , (char)second
                            , (char)third);
                    }
                }
            }
        }
    }
}
