using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool run = true;

            while (run)
            {
                string[] com = Console.ReadLine().Split(' ');

                switch (com[0])
                {
                    case "add":
                        nums.Insert(int.Parse(com[1]), int.Parse(com[2]));
                        break;
                    case "addMany":
                        List<int> elToAdd = com.Skip(2).Select(int.Parse).ToList();
                        nums.InsertRange(int.Parse(com[1]), elToAdd);
                        break;
                    case "contains":
                        Console.WriteLine(nums.IndexOf(int.Parse(com[1])));
                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(com[1]));
                        break;
                    case "shift":
                        Shift(nums, int.Parse(com[1]));
                        break;
                    case "sumPairs":
                        List<int> newList = new List<int>();
                        for (int i = 0; i < nums.Count - 1; i += 2)
                        {
                            newList.Add(nums[i] + nums[i + 1]);
                        }
                        if (nums.Count % 2 == 1)
                        {
                            newList.Add(nums[nums.Count - 1]);
                        }
                        nums = newList;
                        break;
                    case "print":
                        run = false;
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }

        static void Shift(List<int> nums, int pos)
        {
            pos = pos % nums.Count;
            for (int i = 0; i < pos; i++)
            {
                nums.Add(nums[0]);
                nums.RemoveAt(0);
            }
        }
    }
}
