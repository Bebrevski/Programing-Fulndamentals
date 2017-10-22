using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            List<long> hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetsSum = hornets.Sum();
                // Да се внимава пак с типовете данни.
                //В условието пише, че има вход със стойност 1 000 000
                //Съответно сумата от всички инпути може да надхвърли инт 
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (beehives[i] >= hornetsSum)
                {
                    beehives[i] -= hornetsSum;
                    hornets.RemoveAt(0);

                    if (beehives[i].Equals(0))
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                    if (hornets.Count.Equals(0))
                    {
                        break;
                    }
                }
                else
                {
                    beehives.RemoveAt(i);
                    i--;
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
