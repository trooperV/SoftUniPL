using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{, [, (, ), ], }
            // {[]()}
            string input = Console.ReadLine();

            Stack<char> open = new Stack<char>();
            bool n = true;
            foreach (char c in input)
            {
                switch (c)
                {
                    case '{':
                    case '[':
                    case '(':
                        open.Push(c);
                        break;
                    case '}':
                        if (open.Count != 0 && open.Peek() == '{')
                        {
                            open.Pop();
                        }
                        else
                        {
                            n = false;
                        }
                        break;
                    case ']':
                        if (open.Count != 0 && open.Peek() == '[')
                        {
                            open.Pop();
                        }
                        else
                        {
                            n = false;
                        }
                        break;
                    case ')':
                        if(open.Count != 0 && open.Peek() == '(')
                        {
                            open.Pop();
                        }
                        else
                        {
                            n = false;
                        }
                        break;
                }
            }

            if (n) Console.WriteLine("YES"); else Console.WriteLine("NO");
        }
    }
}
