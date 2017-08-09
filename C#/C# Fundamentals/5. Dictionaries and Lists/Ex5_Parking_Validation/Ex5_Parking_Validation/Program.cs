using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> people = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string user = input[1];

                switch (command.ToLower())
                {
                    case "register":
                        string license = input[2];
                        Register(people, user, license);
                        break;
                    case "unregister":
                        Unregister(people, user);
                        break;
                }
            }

            foreach (KeyValuePair<string, string> user in people)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool CheckNumber(string license)
        {
            bool letters = license.ToCharArray().Take(2).Concat(license.ToCharArray().Skip(6).Take(2).ToArray()).All(x => char.IsUpper(x));
            bool nums = license.ToCharArray().Skip(2).Take(4).All(x => char.IsDigit(x));
            return letters && nums;
        }

        static void Register(Dictionary<string, string> people ,string user, string license)
        {
            if (people.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: already registered with plate number {people[user]}");
                return;
            }

            if (!CheckNumber(license))
            {
                Console.WriteLine($"ERROR: invalid license plate {license}");
                return;
            }

            if (people.ContainsValue(license))
            {
                Console.WriteLine($"ERROR: license plate {license} is busy");
                return;
            }

            people.Add(user, license);
            Console.WriteLine($"{user} registered {license} successfully");
            return;
        }

        static void Unregister(Dictionary<string, string> people, string user)
        {
            if (!people.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: user {user} not found");
                return;
            }

            Console.WriteLine($"user {user} unregistered successfully");
            people.Remove(user);
            return;
        }
    }
}
