using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Stars__Dragon_Army
{
    class DragonStats
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, DragonStats>> record =
                new Dictionary<string, Dictionary<string, DragonStats>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string type = tokens[0];
                string name = tokens[1];


                int damage = tokens[2] != "null" ? int.Parse(tokens[2]) : 45;
                int health = tokens[3] != "null" ? int.Parse(tokens[3]) : 250;
                int armor = tokens[4] != "null" ? int.Parse(tokens[4]) : 10;


                if (!record.ContainsKey(type))
                {
                    record.Add(type, new Dictionary<string, DragonStats>());
                }
                if (!record[type].ContainsKey(name))
                {
                    record[type].Add(name, new DragonStats());
                }

                DragonStats currentDragon = new DragonStats()
                {
                    Damage = damage,
                    Health = health,
                    Armor = armor
                };

                record[type][name] = currentDragon;
            }

            double averageDamage = 0;
            double averageHealth = 0;
            double averageArmor = 0;
            foreach (KeyValuePair<string, Dictionary<string, DragonStats>> dragon in record)
            {
                foreach (KeyValuePair<string, DragonStats> kvp in dragon.Value)
                {
                    averageDamage += kvp.Value.Damage;
                    averageHealth += kvp.Value.Health;
                    averageArmor += kvp.Value.Armor;
                }

                averageDamage /= dragon.Value.Count();
                averageHealth /= dragon.Value.Count();
                averageArmor /= dragon.Value.Count();

                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})"
                    , dragon.Key
                    , averageDamage
                    , averageHealth
                    , averageArmor);

                foreach (KeyValuePair<string, DragonStats> name in dragon.Value.OrderBy(d => d.Key))
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}"
                        , name.Key
                        , name.Value.Damage
                        , name.Value.Health
                        , name.Value.Armor);
                }

                averageDamage = 0;
                averageHealth = 0;
                averageArmor = 0;
            }
        }
    }
}

















































//  public static void Main()
//  {
//      var dragons = new Dictionary<string, SortedDictionary<string, double[]>>();

//      int dragonsCount = int.Parse(Console.ReadLine());

//      for (int i = 0; i < dragonsCount; i++)
//      {
//          string[] arguments = Console.ReadLine().Split(' ');

//          string dragonType = arguments[0];
//          string dragonName = arguments[1];
//          double dragonDamage = 0;
//          double dragonHealth = 0;
//          double dragonArmor = 0;

//          dragonDamage = arguments[2] != "null" ? double.Parse(arguments[2]) : 45;
//          dragonHealth = arguments[3] != "null" ? double.Parse(arguments[3]) : 250;
//          dragonArmor = arguments[4] != "null" ? double.Parse(arguments[4]) : 10;

//          if (!dragons.ContainsKey(dragonType))
//          {
//              dragons[dragonType] = new SortedDictionary<string, double[]>();
//          }

//          if (!dragons[dragonType].ContainsKey(dragonName))
//          {
//              dragons[dragonType][dragonName] = new[] { 0d, 0d, 0d };
//          }

//          dragons[dragonType][dragonName] = new[] { dragonDamage, dragonHealth, dragonArmor };
//      }

//      foreach (var type in dragons)
//      {
//          double averageDamage = type.Value.Values.Average(avg => avg[0]);
//          double averageHealth = type.Value.Values.Average(avg => avg[1]);
//          double averageArmor = type.Value.Values.Average(avg => avg[2]);

//          Console.WriteLine($"{type.Key}::" +
//                            $"({averageDamage:f2}" +
//                            $"/{averageHealth:f2}/" +
//                            $"{averageArmor:f2})");

//          foreach (var dragon in dragons[type.Key])
//          {
//              Console.WriteLine($"-{dragon.Key} -> " +
//                                $"damage: {dragon.Value[0]:f0}, " +
//                                $"health: {dragon.Value[1]:f0}, " +
//                                $"armor: {dragon.Value[2]:f0}");
//          }
//      }
//}



 //public static void Main()
 //{
 //    //Nested dictionary for the dragons => the nested dictionary is for names and stats
 //    var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

 //    //N-line inputs
 //    int n = int.Parse(Console.ReadLine());

 //    //Read all dragons
 //    for (int i = 1; i <= n; i++)
 //    {
 //        string line = Console.ReadLine();
 //        var tokens = line.Split().ToArray();

 //        string type = tokens[0];
 //        string name = tokens[1];

 //        decimal damage = tokens[2] != "null" ? decimal.Parse(tokens[2]) : 45;
 //        decimal health = tokens[3] != "null" ? decimal.Parse(tokens[3]) : 250;
 //        decimal armor = tokens[4] != "null" ? decimal.Parse(tokens[4]) : 10;

 //        if (!dragons.ContainsKey(type))
 //        {
 //            dragons[type] = new SortedDictionary<string, decimal[]>();
 //        }
 //        dragons[type][name] = new[] { damage, health, armor };
 //    }

 //    //Print all dragons by the type
 //    foreach (var dragonType in dragons)
 //    {
 //        var type = dragonType.Key;
 //        var dragon = dragonType.Value;
 //        var avgDamage = dragonType.Value.Values.Average(x => x[0]);
 //        var avgHealth = dragonType.Value.Values.Average(x => x[1]);
 //        var avgArmor = dragonType.Value.Values.Average(x => x[2]);
 //        Console.WriteLine($"{type}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");

 //        //Print all dragons and theirs stats by the name
 //        foreach (var drag in dragon)
 //        {
 //            var dragName = drag.Key;
 //            var dragDamage = drag.Value[0];
 //            var dragHealth = drag.Value[1];
 //            var dragArmor = drag.Value[2];
 //            Console.WriteLine($"-{dragName} -> damage: {dragDamage}, health: {dragHealth}, armor: {dragArmor}");
 //        }
 //    }
 //}
