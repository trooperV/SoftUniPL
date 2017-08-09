using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_TeamWork_Projects
{
    class Team
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Memebers { get; set; }
        public int Count { get { return Memebers.Count; } }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                Team temp = new Team();
                temp.Creator = input[0];
                temp.Name = input[1];

                if(teams.Any(a => a.Name == temp.Name))
                {
                    Console.WriteLine($"Team {temp.Name} was already created!");
                    continue;
                }else if(teams.Any(a => a.Creator == temp.Creator))
                {
                    Console.WriteLine($"{temp.Creator} cannot create another team!");
                    continue;
                }
                Console.WriteLine($"Team {temp.Name} has been created by {temp.Creator}!");
                temp.Memebers = new List<string>();
                temp.Memebers.Add(temp.Creator);
                teams.Add(temp);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.None);

                if (input[0] == "end of assignment") break;

                if(!teams.Any(a => a.Name == input[1])){
                    Console.WriteLine($"Team {input[1]} does not exist!");
                    continue;
                }else if(teams.Any(a => a.Memebers.Contains(input[0]))){
                    Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                    continue;
                }

                teams.First(a => a.Name == input[1]).Memebers.Add(input[0]);
            }

            foreach (Team team in teams.OrderByDescending(a => a.Count).ThenBy(a => a.Name))
            {
                if(team.Memebers.Count > 1)
                {
                    Console.WriteLine(team.Name);
                    Console.WriteLine($"- {team.Creator}");
                    foreach (string member in team.Memebers.OrderBy(a => a))
                    {
                        if(member != team.Creator)
                        {
                            Console.WriteLine($"-- {member}");
                        }
                    }
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teams.OrderBy(a => a.Name))
            {
                if(team.Memebers.Count < 2)
                {
                    Console.WriteLine(team.Name);
                }
            }
        }
    }
}
