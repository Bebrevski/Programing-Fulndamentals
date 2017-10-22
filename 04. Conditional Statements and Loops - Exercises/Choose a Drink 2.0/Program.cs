using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profesion = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            if (profesion == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profesion, quantity * 0.7);

            }
            else if (profesion == "Businessman" || profesion == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profesion, quantity * 1);
            }
            else if (profesion == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profesion, quantity * 1.7);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profesion, quantity * 1.2);
            }
        }
    }
}
