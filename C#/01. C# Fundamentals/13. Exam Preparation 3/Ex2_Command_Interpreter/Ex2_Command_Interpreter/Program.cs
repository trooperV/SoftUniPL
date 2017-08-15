using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = 
                Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end") break;

                //•	"reverse from [start] count [count]"
                //•	"sort from [start] count [count]"
                //•	"rollLeft [count] times"
                //•	"rollRight [count] times"
                int count = 0;
                int start = 0;
                switch (input[0])
                {
                    case "reverse":
                        start = int.Parse(input[2]);
                        count = int.Parse(input[4]);
                        if (start < 0 || start >= strings.Count || count < 0 || start + count > strings.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        int i2 = 1;
                        for (int i = start; i < start + count / 2; i++, i2++)
                        {
                            string temp = strings[i];
                            strings[i] = strings[start + count - i2];
                            strings[start + count - i2] = temp;
                        }
                        break;
                    case "sort":
                        start = int.Parse(input[2]);
                        count = int.Parse(input[4]);
                        if (start < 0 || start >= strings.Count || count < 0 || start + count > strings.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        strings.Sort(start, count, StringComparer.InvariantCulture);

                        break;
                    case "rollLeft":
                        count = int.Parse(input[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        count = count % strings.Count;
                        for (int i = 0; i < count; i++)
                        {
                            string temp = strings[0];
                            strings.RemoveAt(0);
                            strings.Add(temp);
                        }
                        break;
                    case "rollRight":
                        count = int.Parse(input[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        count = count % strings.Count;
                        strings.Reverse();
                        for (int i = 0; i < count; i++)
                        {
                            string temp = strings[0];
                            strings.RemoveAt(0);
                            strings.Add(temp);
                        }
                        strings.Reverse();
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", strings) + "]");
        }
    }
}
