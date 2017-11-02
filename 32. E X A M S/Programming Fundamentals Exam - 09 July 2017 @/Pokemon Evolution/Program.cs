using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evolution
{
    class PokeMon
    {
        public string EvolutionType { get; set; }
        public long EvolutionIndex { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<PokeMon>> record =
                new Dictionary<string, List<PokeMon>>();

            string input = Console.ReadLine();

            while (!input.Equals("wubbalubbadubdub"))
            {
                string[] tokens = input
                    .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToArray();

                string rareName = tokens[0];

                if (tokens.Length.Equals(1) && record.ContainsKey(rareName))
                {
                    Console.WriteLine("# {0}", rareName);

                    foreach (PokeMon pok in record[rareName])
                    {
                        Console.WriteLine("{0} <-> {1}"
                            , pok.EvolutionType
                            , pok.EvolutionIndex);
                    }
                }
                else
                {
                    string pokemonName = tokens[0];
                    string evolutionType = tokens[1];
                    long evolutionIndex = long.Parse(tokens[2]);

                    if (!record.ContainsKey(pokemonName))
                    {
                        record.Add(pokemonName, new List<PokeMon>());
                    }

                    PokeMon currentPokemon = new PokeMon()
                    {
                        EvolutionType = evolutionType,
                        EvolutionIndex = evolutionIndex
                    };

                    record[pokemonName].Add(currentPokemon);
                }

                input = Console.ReadLine();
            }


            foreach (KeyValuePair<string, List<PokeMon>> pokemon in record)
            {
                Console.WriteLine("# {0}", pokemon.Key);

                foreach (PokeMon pok in
                    pokemon.Value.OrderByDescending(index => index.EvolutionIndex))
                {
                    Console.WriteLine("{0} <-> {1}"
                        , pok.EvolutionType
                        , pok.EvolutionIndex);
                }
            }
        }
    }
}
