using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine("{0} = {1}", "a", a);
            Console.WriteLine("{0} = {1}", "b", b);

            Console.WriteLine("After:");
            Console.WriteLine("{0} = {1}", "a", b);
            Console.WriteLine("{0} = {1}", "b", a);
        }
    }
}
