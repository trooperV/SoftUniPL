using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex3_Nether_Realms
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public decimal Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //"{demon name} - {health points} health, {damage points} damage"
            List<string> names = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(a => a).ToList();
            //Console.WriteLine(string.Join("\n", names));
            string patternL = @"[^0-9*\/.+\-]";
            string patternN = @"-?[0-9]+(\.[0-9]+)?";

            List<Demon> demons = new List<Demon>();

            foreach (string name in names)
            {
                Demon temp = new Demon();
                temp.Name = name;

                MatchCollection nameCharMatches = Regex.Matches(name, patternL);

                int charSumT = 0;
                foreach (Match c in nameCharMatches)
                {
                    charSumT += char.Parse(c.Value);
                }

                temp.Health = charSumT;

                MatchCollection numCharMatches = Regex.Matches(name, patternN);

                decimal numSumT = 0;
                foreach (Match c in numCharMatches)
                {
                    numSumT += decimal.Parse(c.Value);
                }

                int assN = Regex.Matches(name, @"\*").Count;
                int delN = Regex.Matches(name, @"\\").Count;

                foreach (char c in name.Where(c => c == '*' || c == '/'))
                {
                    if (c == '*')
                    {
                        numSumT *= 2;
                    }
                    else
                    {
                        numSumT /= 2;
                    }
                }

                temp.Damage = numSumT;

                demons.Add(temp);
            }

            foreach (Demon demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}
