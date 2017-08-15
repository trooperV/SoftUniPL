using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> previousCommands = new Stack<string>();
            string text = "";

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "1":
                        previousCommands.Push(text);
                        text += commands[1];
                        break;
                    case "2":
                        previousCommands.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(commands[1]));
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;
                    case "4":
                        text = previousCommands.Pop();
                        break;
                }
            }
        }
    }
}
