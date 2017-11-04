using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int portions = (int)Math.Ceiling(guests / 6.0);

            double moneyForProducts = (double)portions * (2 * bananaPrice) + (double)portions * (4 * eggPrice) + (double)portions * (0.2 * berriesPrice);

            if (moneyForProducts<=money)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv."
                    ,moneyForProducts);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more."
                    ,moneyForProducts-money);
            }
        }
    }
}
