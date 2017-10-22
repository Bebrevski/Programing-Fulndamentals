using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var cheese = 0;
            var tomatoSause = 0;
            var salami = 0;
            var pepper = 0;

            for (int i = 1; i <= n; i++)
            {
                var ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    cheese += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    tomatoSause += 150;
                }
                else if (ingredients == "salami")
                {
                    salami += 600;
                }
                else if (ingredients == "pepper")
                {
                    pepper += 50;
                }
            }

            Console.WriteLine("Total calories: {0}", cheese + tomatoSause + salami + pepper);
        }
    }
}
