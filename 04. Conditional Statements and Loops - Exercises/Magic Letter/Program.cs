using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = Console.ReadLine();
            string secondLetter = Console.ReadLine();
            string controlLetter = Console.ReadLine();

            for (var i = firstLetter[0]; i <= secondLetter[0]; i++)
                for (var j = firstLetter[0]; j <= secondLetter[0]; j++)
                    for (var k = firstLetter[0]; k <= secondLetter[0]; k++)
                    {
                        if (i == controlLetter[0] || j == controlLetter[0] || k == controlLetter[0])
                        {
                            continue;
                        }
                        Console.Write("{0}{1}{2} ",i,j,k);
                    }

        }
    }
}

