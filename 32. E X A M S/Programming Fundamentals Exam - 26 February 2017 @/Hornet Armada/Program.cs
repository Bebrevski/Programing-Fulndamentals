using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Armada
{

    class Program
    {
        static void Main(string[] args)
        {
            //

            Dictionary<string, long> legionAndActibity =
                new Dictionary<string, long>();

            Dictionary<string, Dictionary<string, long>> legionSoldierTypeAndCoun =
                new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ->:=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                long activity = long.Parse(tokens[0]);
                string legion = tokens[1];
                string soldierType = tokens[2];
                long sodierCount = long.Parse(tokens[3]);

                if (!legionSoldierTypeAndCoun.ContainsKey(legion))
                {
                    legionSoldierTypeAndCoun.Add(legion, new Dictionary<string, long>());

                    legionAndActibity.Add(legion, activity);
                }
                else if (legionAndActibity[legion] < activity)
                {
                    legionAndActibity[legion] = activity;
                }
                if (!legionSoldierTypeAndCoun[legion].ContainsKey(soldierType))
                {
                    legionSoldierTypeAndCoun[legion].Add(soldierType, 0);
                }

                legionSoldierTypeAndCoun[legion][soldierType] += sodierCount;
            }

            string[] lastInput = Console.ReadLine()
                .Split('\\')
                .ToArray();

            //Внимание към сортирането !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1

            if (lastInput.Length > 1)
            {
                long activity = long.Parse(lastInput[0]);
                string soldierType = lastInput[1];

                foreach (KeyValuePair<string, Dictionary<string, long>> legion in
                    legionSoldierTypeAndCoun.Where(legion => legion.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {
                    if (legionAndActibity[legion.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}"
                            , legion.Key
                            , legion.Value[soldierType]);
                    }
                }
            }
            else
            {
                string soldierType = lastInput[0];

                foreach (KeyValuePair<string, long> legion in
                    legionAndActibity.OrderByDescending(legion => legion.Value))
                {
                    if (legionSoldierTypeAndCoun[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine("{0} : {1}"
                            , legion.Value
                            , legion.Key);
                    }
                }
            }

            
        }
    }
}
