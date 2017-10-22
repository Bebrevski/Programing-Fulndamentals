using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());

            var none = false;

            for (int i = numberOne; i <= numberTwo; i++)
            {
                for (int j = i+1; j <= numberTwo; j++)
                {
                    for (int k = j+1; k <= numberTwo; k++)
                    {
                        for (int l = k+1; l <= numberTwo; l++)
                        {
                            for (int m = l+1; m <= numberTwo; m++)
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4}",i,j,k,l,m);
                                none = true;
                            }
                        }
                    }
                }
            }
            if (none == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
