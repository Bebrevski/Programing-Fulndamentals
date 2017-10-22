using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ressurection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long length = long.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                long wing = long.Parse(Console.ReadLine());

                decimal totalYears = (decimal)Math.Pow(length, 2) * (width + (2 * wing));


                Console.WriteLine(totalYears);
            }
        }
    }
}
