using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(number,0));
        }
    }
}
