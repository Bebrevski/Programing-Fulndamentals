using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var bake = string.Empty;
            var counter = 0;

            do
            {
                var ingredient = Console.ReadLine();
                bake = ingredient;
                if (ingredient != "Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.", ingredient);
                    counter++;
                }

            } while (bake != "Bake!");

            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
