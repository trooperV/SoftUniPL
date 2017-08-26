using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Party!") break;

                bool wc = false;
                if (input[0] == "Double") wc = true;

                switch (input[1])
                {
                    case "EndsWith": names = new List<string>(EndsWithP(wc, input[2], names)); break;
                    case "StartsWith": names = new List<string>(StartsWithP(wc, input[2], names)); break;
                    case "Length": names = new List<string>(LengthP(wc, int.Parse(input[2]), names)); break;
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
        }

        static List<string> EndsWithP(bool wc, string str, List<string> ls)
        {
            List<string> nLs = new List<string>(ls);
            Predicate<string> isValid = n => n.EndsWith(str);
            if (!wc) nLs.RemoveAll(isValid);
            if (wc)
            {
                foreach (string name in ls)
                {
                    if (isValid(name))
                    {
                        nLs.Add(name);
                    }
                }
            }
            return nLs;
        }

        static List<string> StartsWithP(bool wc, string str, List<string> ls)
        {
            List<string> nLs = new List<string>(ls);
            Predicate<string> isValid = n => n.StartsWith(str);
            if (!wc) nLs.RemoveAll(isValid);
            if (wc)
            {
                foreach (string name in ls)
                {
                    if (isValid(name))
                    {
                        nLs.Add(name);
                    }
                }
            }
            return nLs;
        }

        static List<string> LengthP(bool wc, int len, List<string> ls)
        {
            List<string> nLs = new List<string>(ls);
            foreach (string name in ls)
            {
                Predicate<string> isValid = n => n.Length == len;
                if (isValid(name) && !wc)
                {
                    nLs.Remove(name);
                }
                else if (isValid(name) && wc)
                {
                    nLs.Add(name);
                }
            }
            return nLs;
        }
    }
}
