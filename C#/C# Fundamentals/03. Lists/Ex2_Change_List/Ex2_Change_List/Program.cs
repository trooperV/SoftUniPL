using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Change_List
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
                    case "Delete":
                        Delete(nums, com);
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(com[2]), int.Parse(com[1]));
                        break;
                    case "Even":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if(nums[i] % 2 == 0)
                            {
                                Console.Write(nums[i] + " ");
                            }
                        }
                        run = false;
                        break;
                    case "Odd":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 != 0)
                            {
                                Console.Write(nums[i] + " ");
                            }
                        }
                        run = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static void Delete(List<int> nums, string[] com)
        {
            if (nums.Remove(int.Parse(com[1])))
            {
                Delete(nums, com);
            }
            else
            {
                return;
            }
        }
    }
}
