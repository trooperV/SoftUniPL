using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex4_Files
{
    class Files
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public string Ext { get; set; }
        public long Kb { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Files> files = new List<Files>();
            string pattern = @"(?<root>[\w ;:\.]+)\\+(.+\\+)*(?<file>.+)\.(?<ext>.+);(?<kb>\d+)"; // this shit is golden
            int n = int.Parse(Console.ReadLine());
            Regex reg = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!reg.IsMatch(input)) continue;
                Match match = reg.Match(input);
                StringBuilder sb = new StringBuilder();
                sb.Append(match.Groups["file"].ToString());
                sb.Append(".");
                sb.Append(match.Groups["ext"].ToString());
                string fileName = sb.ToString();
                long kb = long.Parse(match.Groups["kb"].ToString());
                string rootName = match.Groups["root"].ToString();
                string ext = match.Groups["ext"].ToString();

                if (files.Any(a => a.Root == rootName))
                {
                    if (files.First(a => a.Root == rootName).Name.Equals(fileName))
                    {
                        files.First(a => a.Root == rootName).Kb = kb;
                        continue;
                    }
                }

                Files temp = new Files();
                temp.Name = fileName;
                temp.Root = rootName;
                temp.Kb = kb;
                temp.Ext = ext;

                files.Add(temp);
            }

            string[] ex = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string ext1 = ex[0];
            string root1 = ex[2];

            bool isNo = true;
            foreach (Files file in files.OrderByDescending(a => a.Kb).ThenBy(a => a.Name))
            {
                if (file.Root.Equals(root1) && file.Ext == ext1)
                {
                    isNo = false;
                    Console.WriteLine($"{file.Name} - {file.Kb} KB");
                }
            }
            if (isNo)
            {
                Console.WriteLine("No");
            }
        }

        //        class Root
        //        {
        //            public string Name { get; set; }
        //            public Dictionary<string, long> Files { get; set; }
        //        }

        //        class Program
        //        {
        //            static void Main(string[] args)
        //            {
        //                List<Root> roots = new List<Root>();
        //                string pattern = @"(?<root>[\w ;:\.]+)\\+(.+\\+)*(?<file>.+)\.(?<ext>.+);(?<kb>\d+)";

        //                int n = int.Parse(Console.ReadLine());
        //                Regex reg = new Regex(pattern);
        //                for (int i = 0; i < n; i++)
        //                {
        //                    string input = Console.ReadLine();
        //                    if (!reg.IsMatch(input)) continue;
        //                    Match match = reg.Match(input);
        //                    StringBuilder sb = new StringBuilder();
        //                    sb.Append(match.Groups["file"].ToString());
        //                    sb.Append(".");
        //                    sb.Append(match.Groups["ext"].ToString());
        //                    string fileName = sb.ToString();
        //                    long kb = long.Parse(match.Groups["kb"].ToString());
        //                    string rootName = match.Groups["root"].ToString();

        //                    if (roots.Any(a => a.Name == rootName))
        //                    {
        //                        if (roots.First(a => a.Name == rootName).Files.ContainsKey(fileName))
        //                        {
        //                            roots.First(a => a.Name == rootName).Files[fileName] = kb;
        //                        }
        //                        else
        //                        {
        //                            roots.First(a => a.Name == rootName).Files.Add(fileName, kb);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Root temp = new Root();
        //                        temp.Name = rootName;
        //                        temp.Files = new Dictionary<string, long>();
        //                        temp.Files[fileName] = kb;

        //                        roots.Add(temp);
        //                    }
        //                }

        //                string[] ex = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        //                string ext1 = ex[0];
        //                string root1 = ex[2];

        //                bool isNo = true;
        //                foreach (Root root in roots)
        //                {
        //                    if (root.Name == root1)
        //                    {
        //                        foreach (KeyValuePair<string, long> file in root.Files.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
        //                        {
        //                            if (file.Key.Substring(file.Key.Length - ext1.Length, ext1.Length).Equals(ext1))
        //                            {
        //                                isNo = false;
        //                                Console.WriteLine($"{file.Key} - {file.Value} KB");
        //                            }
        //                        }
        //                    }
        //                }
        //                if (isNo)
        //                {
        //                    Console.WriteLine("No");
        //                }
        //            }
    }
}

