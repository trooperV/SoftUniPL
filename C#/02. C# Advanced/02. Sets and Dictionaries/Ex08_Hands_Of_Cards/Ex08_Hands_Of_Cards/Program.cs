using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Hands_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AllCards = new Dictionary<string, int>();


            while (true)
            {
                var tokens = Console.ReadLine().Split(':');
                if (tokens[0] == "JOKER") break;
                var name = tokens[0];
                var cards = tokens[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(CalculateCards).ToList();
                var cards1 = cards.Distinct();
                AllCards[name] = cards1.Sum();
            }

            foreach (var item in AllCards)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }

        static int CalculateCards(string card)
        {

            Dictionary<string, int> powers = new Dictionary<string, int>();

            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }

            Dictionary<string, int> types = new Dictionary<string, int>();

            types["S"] = 4;
            types["H"] = 3;
            types["D"] = 2;
            types["C"] = 1;

            var power = card.Substring(0, card.Length - 1);
            var type = card[card.Length - 1].ToString();

            return powers[power] * types[type];
        }
    }
}
