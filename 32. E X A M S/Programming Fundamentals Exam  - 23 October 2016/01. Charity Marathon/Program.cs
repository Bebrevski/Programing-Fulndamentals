using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine()); //int.MaxValue
            int averageLaps = int.Parse(Console.ReadLine());
            int lapLenght = int.Parse(Console.ReadLine()); //int.MaxValue
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilomiter = double.Parse(Console.ReadLine());

            BigInteger maxRunners = BigInteger.Min(days * trackCapacity, runners);

            BigInteger totalMeters = maxRunners * averageLaps * lapLenght;
            double totalKilomiters = (double)totalMeters / (double)1000; //decimal,double
            double raisedMoney = (double)totalKilomiters * (double)moneyPerKilomiter;

            Console.WriteLine("Money raised: {0:f2}",raisedMoney);

        }
    }
}
