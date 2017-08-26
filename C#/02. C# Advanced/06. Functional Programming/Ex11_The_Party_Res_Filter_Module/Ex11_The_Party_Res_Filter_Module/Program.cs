using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_The_Party_Res_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Dictionary<string, HashSet<string>> dic = new Dictionary<string, HashSet<string>>();
            dic.Add("Starts with", new HashSet<string>());
            dic.Add("Ends with", new HashSet<string>());
            dic.Add("Length", new HashSet<string>());
            dic.Add("Contains", new HashSet<string>());
            while (true)
            {
                string[] input = Console.ReadLine().Split(';');
                if (input[0] == "Print") break;

                Predicate<string> fFilter = a => a.StartsWith("Add");
                if (fFilter(input[0]))
                {
                    switch (input[1])
                    {
                        case "Starts with":
                            dic["Starts with"].Add(input[2]);
                            break;
                        case "Ends with":
                            dic["Ends with"].Add(input[2]);
                            break;
                        case "Length":
                            dic["Length"].Add(input[2]);
                            break;
                        case "Contains":
                            dic["Contains"].Add(input[2]);
                            break;
                    }
                }
                else
                {
                    switch (input[1])
                    {
                        case "Starts with":
                            dic["Starts with"].Remove(input[2]);
                            break;
                        case "Ends with":
                            dic["Ends with"].Remove(input[2]);
                            break;
                        case "Length":
                            dic["Length"].Remove(input[2]);
                            break;
                        case "Contains":
                            dic["Contains"].Remove(input[2]);
                            break;
                    }
                }
            }
                foreach (KeyValuePair<string, HashSet<string>> item in dic)
                {

                    switch (item.Key)
                    {
                        case "Starts with":
                            foreach (string str in item.Value)
                            {
                                Predicate<string> startsWith = a => a.StartsWith(str);
                                names.RemoveAll(startsWith);
                            }
                            break;
                        case "Ends with":
                            foreach (string str in item.Value)
                            {
                                Predicate<string> endsWith = a => a.EndsWith(str);
                                names.RemoveAll(endsWith);
                            }

                            break;
                        case "Length":
                            foreach (string str in item.Value)
                            {
                                Predicate<string> length = a => a.Length == int.Parse(str);
                                names.RemoveAll(length);
                            }

                            break;
                        case "Contains":
                            foreach (string str in item.Value)
                            {
                                Predicate<string> contains = a => a.Contains(str);
                                names.RemoveAll(contains);
                            }
                            break;
                    }
                }

                Console.WriteLine(string.Join(" ", names));
            }
        }
    }