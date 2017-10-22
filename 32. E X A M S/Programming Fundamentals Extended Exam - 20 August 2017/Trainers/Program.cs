using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, float> record = new Dictionary<string, float>();

            for (int i = 0; i < n; i++)
            {
                float distance = float.Parse(Console.ReadLine()) * 1600;
                float cargo = float.Parse(Console.ReadLine()) * 1000;
                string team = Console.ReadLine();

                float fuelConsumation = distance * (float)0.7 * (float)2.5;
                float cargoIncome = cargo * (float)1.5;

                float earnedMoneyOfTeam = cargoIncome - fuelConsumation;

                if (!record.ContainsKey(team))
                {
                    record.Add(team, 0);
                }
                record[team] += earnedMoneyOfTeam;

            }

            record = record.OrderByDescending(t => t.Value)
                .ToDictionary(t => t.Key, t => t.Value);

            Console.WriteLine("The {0} Trainers win with ${1:f3}."
                , record.Keys.First()
                , record.Values.First());
        }
    }
}
