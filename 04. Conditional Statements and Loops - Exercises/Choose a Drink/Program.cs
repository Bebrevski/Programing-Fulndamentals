using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();

            if (proffesion=="Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (proffesion=="SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else 
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
