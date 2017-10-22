using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_projects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> AddedMembers { get; set; }
        public string Creator { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> record = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                string team = input[1];
                string user = input[0];

                if (!record.Any(teams => teams.TeamName.Equals(team)))
                {
                    if (!record.Any(creators => creators.Creator.Equals(user)))
                    {
                        Team currentTeam = new Team()
                        {
                            TeamName = team,
                            Creator = user,
                            AddedMembers = new List<string>()
                        };

                        record.Add(currentTeam);

                        Console.WriteLine("Team {0} has been created by {1}!"
                            , team
                            , user);
                    }
                    else
                    {
                        Console.WriteLine("{0} cannot create another team!", user);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", team);
                }
            }

            string lines = Console.ReadLine();

            while (!lines.Equals("end of assignment"))
            {
                string[] tokens = lines.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string teamToJoin = tokens[1];

                if (record.Any(team => team.TeamName.Equals(teamToJoin)))
                {
                    if (!(record.Any(user => user.Creator.Equals(name)) ||
                          record.Any(user => user.AddedMembers.Contains(name))))
                    {
                        for (int i = 0; i < record.Count; i++)
                        {
                            if (record[i].TeamName.Equals(teamToJoin))
                            {
                                record[i].AddedMembers.Add(name);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Member {0} cannot join team {1}!"
                            , name
                            , teamToJoin);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} does not exist!", teamToJoin);
                }

                lines = Console.ReadLine();
            }

            List<string> teamsToDisband = new List<string>();

            teamsToDisband = record.Where(t => t.AddedMembers.Count == 0).Select(x => x.TeamName).ToList();

            foreach (Team team in record.OrderByDescending(team => team.AddedMembers.Count())
                                        .ThenBy(team => team.TeamName))
            {
                if (team.AddedMembers.Count.Equals(0))
                {
                    continue;
                }
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- {0}", team.Creator);

                foreach (string mem in team.AddedMembers.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0}", mem);
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (string str in teamsToDisband.OrderBy(x => x))
            {
                Console.WriteLine(str);
            }
        }
    }
}
