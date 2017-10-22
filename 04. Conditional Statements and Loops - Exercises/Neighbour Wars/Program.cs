using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;

            var roundCounter = 1;
            var name = "Pesho";

            while ((peshoHealth > 0 || goshoHealth > 0) && peshoDamage != 100 && goshoDamage != 100)
            {
                if (roundCounter % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    name = "Gosho";
                    if (peshoHealth <= 0) break;
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                }
                else
                {
                    goshoHealth -= peshoDamage;
                    name = "Pesho";
                    if (goshoHealth <= 0) break;
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                }

                if (roundCounter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                roundCounter++;
            }

            Console.WriteLine("{0} won in {1}th round.", name, roundCounter);

        }
    }
}
