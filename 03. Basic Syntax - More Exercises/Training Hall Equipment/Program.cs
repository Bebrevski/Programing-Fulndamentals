using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            double subtotal = 0;

            for (int i = 1; i <= numberOfItems; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                name = count > 1 ? name + "s" : name;

                Console.WriteLine("Adding {0} {1} to cart.", count, name);

                subtotal += price*count;
            }

            Console.WriteLine("Subtotal: ${0:f2}", subtotal);
            if (budget > subtotal) Console.WriteLine("Money left: ${0:f2}",budget-subtotal);
            else Console.WriteLine("Not enough. We need ${0:f2} more.",subtotal-budget);
        }
    }
}
