using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int[][] arr1 = new int[n][];
            Stack <int> stack1 = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                stack1.Push(arr1[i].Length);
                count += arr1[i].Length;
            }

            Stack<int> stack2 = new Stack<int>();
            int[][] arr2 = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr2[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();
                stack2.Push(arr2[i].Length);
                count += arr2[i].Length;
            }
            int last = stack1.Peek() + stack2.Peek();
            int nums = stack1.Count;
            bool yes = true;
            for (int i = 0; i < nums; i++)
            {
                if (last != stack1.Pop() + stack2.Pop())
                {
                    Console.WriteLine($"The total number of cells is: {count}");
                    yes = false;
                    break;
                }
            }

            if (yes)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("[" + string.Join(", ", arr1[i].Concat(arr2[i])) + "]");
                }
            }
        }
    }
}
