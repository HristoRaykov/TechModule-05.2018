using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split('-');
                string creator = line[0];
                string teamName = line[1];
                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {                   
                    if (teams.Values.Select(team => team.Creator).Contains(creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                    else
                    {
                        teams.Add(teamName, new Team(teamName, "", new List<string>()));
                        Team currentTeam = teams[teamName];
                        currentTeam.Creator = creator;
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line.Equals("end of assignment"))
                {
                    break;
                }
                string[] tokens = Regex.Split(line, "->");
                string memberName = tokens[0];
                string teamName = tokens[1];

                if (teams.ContainsKey(teamName)==false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    bool isCreator = teams.Values.Select(team => team.Creator).Contains(memberName);
                    bool isMember = teams.Values.SelectMany(team => team.Members).Contains(memberName);
                    if (isCreator || isMember)
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    }
                    else
                    {
                        teams[teamName].Members.Add(memberName);
                        teams[teamName].Members.Sort();
                    }   
                }
            }

            teams = teams.Values.OrderByDescending(team => team.MembersCount).ThenBy(team => team.Name).ToDictionary(t =>t.Name,t=>t);

            List<Team> teamsToDisband = new List<Team>();
            List<Team> teamsToStay = new List<Team>();
            foreach (var team in teams.Values)
            {
                if (team.MembersCount==0)
                {
                    teamsToDisband.Add(team);
                }
                else
                {
                    teamsToStay.Add(team);
                }
            }

            foreach (var team in teamsToStay)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }

    class Team
    {
        public string Name { get; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public int MembersCount { get { return Members.Count; } }

        public Team(string name, string creator, List<string> members)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = members;
        }
    }
}
