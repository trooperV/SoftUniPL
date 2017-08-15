using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> nums = new Stack<int>();
            Stack<int> max = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (input[0])
                {
                    case 1:
                        nums.Push(input[1]);
                        if (max.Count == 0 || max.Peek() < input[1])
                        {
                            max.Push(input[1]);
                        }
                        break;
                    case 2:
                        if (nums.Count > 0)
                        {
                            if (max.Count == 0)
                                nums.Pop();
                            else if (max.Peek() == nums.Pop())
                                max.Pop();
                        }
                        break;
                    case 3:
                        if (nums.Count > 0)
                            Console.WriteLine(max.Peek());
                        break;
                }
            }
        }
    }
}
