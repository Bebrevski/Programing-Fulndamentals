using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float metersPerSecond = (float)distance / (hours * 3600 + minutes * 60 + seconds);
            float kilomitersPerHour = ((float)distance / 1000) / (hours + (float)minutes / 60 + (float)seconds / 3600);
            float milesPerHour = ((float)distance / 1609) / (hours + (float)minutes / 60 + (float)seconds / 3600);

            Console.WriteLine("{0}", metersPerSecond);
            Console.WriteLine("{0}", kilomitersPerHour);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
