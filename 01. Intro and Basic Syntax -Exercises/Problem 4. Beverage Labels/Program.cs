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
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:",volume,name);
            Console.WriteLine("{0}kcal, {1}g sugars",energyContent*volume/100,sugarContent*volume/100);
        }
    }
}
