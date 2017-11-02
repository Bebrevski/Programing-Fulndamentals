using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3__Nether_Realms
{
    class Demon
    {
        public string DemonName { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(d => d.Trim())
                .ToArray();

            List<Demon> record = new List<Demon>();

            foreach (string demon in demons)
            {
                string demonName = demon;

                Regex demonsHealth = new Regex(@"[^0-9+\-*\/\.]");
                Regex demonsDamage = new Regex(@"\-?[.0-9]+");
                Regex amplifier = new Regex(@"[*\/]");

                MatchCollection lettersMatch = demonsHealth.Matches(demon);

                int health = GetDemonHealth(lettersMatch);

                MatchCollection digitsMatch = demonsDamage.Matches(demon);

                double damage = GetDemonDamage(digitsMatch);

                MatchCollection amplifiersMatch = amplifier.Matches(demon);

                damage = GetAmplifiedDamage(amplifiersMatch, damage);

                Demon currentDemon = new Demon()
                {
                    DemonName = demon,
                    Health = health,
                    Damage = damage
                };

                record.Add(currentDemon);
            }

            record = record.OrderBy(d => d.DemonName).ToList();

            foreach (Demon demon in record)
            {
                Console.WriteLine("{0} - {1} health, {2:f2} damage"
                    ,demon.DemonName
                    ,demon.Health
                    ,demon.Damage);
            }
        }

        private static double GetAmplifiedDamage(MatchCollection amplifiersMatch, double damage)
        {
            foreach (Match symbol in amplifiersMatch)
            {
                if (symbol.Value.Equals("*"))
                {
                    damage *= 2;
                }
                else if (symbol.Value.Equals("/"))
                {
                    damage /= 2;
                }
            }

            return damage;
        }
        private static double GetDemonDamage(MatchCollection digitsMatch)
        {
            double damage = 0;

            foreach (Match digit in digitsMatch)
            {
                damage += double.Parse(digit.Value);
            }
            return damage;
        }

        private static int GetDemonHealth(MatchCollection lettersMatch)
        {
            int health = 0;
            foreach (Match symbol in lettersMatch)
            {
                health += char.Parse(symbol.Value);
            }
            return health;
        }
    }
}