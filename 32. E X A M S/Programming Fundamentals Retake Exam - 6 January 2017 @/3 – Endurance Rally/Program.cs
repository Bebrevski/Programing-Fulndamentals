using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();

            double[] trackLayout = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] checkpoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int dr = 0; dr < drivers.Length; dr++)
            {
                int startFuel = drivers[dr][0];
                double start = (double)startFuel;
                int index=0;

                for (int ch = 0; ch < trackLayout.Length; ch++)
                {
                    if (checkpoints.Contains(ch))
                    {
                        start += trackLayout[ch];
                    }
                    else
                    {
                        start -= trackLayout[ch];
                    }

                    if (start <= 0)
                    {
                        index = ch;
                        break;
                    }
                }

                if (start <= 0)
                {
                    Console.WriteLine("{0} - reached {1}"
                        , drivers[dr]
                        , index);
                    continue;
                }
                Console.WriteLine("{0} - fuel left {1:f2}"
                    ,drivers[dr]
                    , start);
            }
        }
    }
}
