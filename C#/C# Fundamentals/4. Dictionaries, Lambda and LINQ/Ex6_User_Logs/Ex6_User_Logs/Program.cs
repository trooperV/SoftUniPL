using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> output = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                if (input[0] == "end") break;
                var ip = input[0].Split('=');
                var user = input[2].Split('=');

                if (!output.ContainsKey(user[1])) output.Add(user[1], new Dictionary<string, int>());
                if (!output[user[1]].ContainsKey(ip[1])) output[user[1]].Add(ip[1], 1);
                else output[user[1]][ip[1]]++;
            }

            foreach (var user in output)
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var log in user.Value)
                {
                    var thing = log.Key;
                    if (log.Key != user.Value.Keys.Last()) Console.Write($"{log.Key} => {log.Value}, ");
                    else Console.WriteLine($"{log.Key} => {log.Value}.");
                }
            }
        }
    }
}
