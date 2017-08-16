using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> inputDict = new SortedDictionary<char, int>();
            foreach (var item in input)
            {
                if (inputDict.ContainsKey(item) == false)
                {
                    inputDict.Add(item, 0);
                }
                inputDict[item]++;
            }

            foreach (KeyValuePair<char, int> pair in inputDict)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
