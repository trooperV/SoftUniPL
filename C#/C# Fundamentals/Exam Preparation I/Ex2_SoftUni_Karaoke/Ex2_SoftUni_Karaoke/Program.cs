using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string[] performance = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            Dictionary<string, List<string>> everything = new Dictionary<string, List<string>>();

            while (!performance[0].Equals("dawn"))
            {
                string person = performance[0];
                string song = performance[1];
                string award = performance[2];

                if (people.Contains(person) && songs.Contains(song))
                {
                    if (!everything.ContainsKey(person))
                    {
                        everything.Add(person, new List<string>());
                        everything[person].Add(award);
                    }
                    else
                    {
                        if (!everything[person].Contains(award))
                        {
                            everything[person].Add(award);
                        }
                    }
                }

                performance = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            }

            if (everything.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (KeyValuePair<string, List<string>> singer in everything.OrderByDescending(p => p.Value.Count()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                string[] awardsCurrentSinger = everything[singer.Key].OrderBy(a => a).ToArray();

                if (awardsCurrentSinger.Length > 0)
                {
                    foreach (string award in awardsCurrentSinger)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
                else
                {
                    Console.WriteLine("No awards");
                }
            }
        }
    }
}
