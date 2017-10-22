using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripDitance = double.Parse(Console.ReadLine());
            double tank = double.Parse(Console.ReadLine());
            double miles = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDitance - miles;

            double nonHeavyConsumation = milesInNonHeavyWinds * 25;
            double heavyWindConsumation = miles * (25 * 1.5);

            double fuelConsumation = nonHeavyConsumation + heavyWindConsumation;

            double tolerance = fuelConsumation * 0.05;

            double totalFuelConsumation = fuelConsumation + tolerance;

            double remainingFuel = tank - totalFuelConsumation;


            Console.WriteLine("Fuel needed: {0:f2}L", totalFuelConsumation);
            if (remainingFuel >= 0)
            {
                Console.WriteLine("Enough with {0:f2}L to spare!", remainingFuel);
            }
            else
            {
                Console.WriteLine("We need {0:f2}L more fuel.", Math.Abs(remainingFuel));
            }
        }
    }
}
