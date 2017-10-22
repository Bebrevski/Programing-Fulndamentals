using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int startedPower = pokePower;
            int counter = 0;

            while (!(pokePower < distance))
            {
                if (pokePower * 2 == startedPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                    continue;
                }

                pokePower -= distance;
                counter++;                            
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
