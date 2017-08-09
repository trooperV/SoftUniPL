using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Play_Catch
{
    class Program
    {
        public static int errorC = 0;
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            
            while (true)
            {
                if (errorC == 3) break;

                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "Replace":

                        if (!checkV(input[1])) break;
                        if (!checkV(input[2])) break;

                        if (int.Parse(input[1]) <= nums.Count - 1 && int.Parse(input[1]) >= 0) {
                            nums[int.Parse(input[1])] = int.Parse(input[2]);
                        }
                        else
                        {
                            Console.WriteLine("The index does not exist!");
                            errorC++;
                        }
                        break;
                    case "Print":

                        if (!checkV(input[1])) break;
                        if (!checkV(input[2])) break;

                        if ((int.Parse(input[1]) <= nums.Count - 1 && int.Parse(input[1]) >= 0) && (int.Parse(input[2]) <= nums.Count - 1 && int.Parse(input[2]) >= 0))
                        {
                            int[] a = nums.GetRange(int.Parse(input[1]), (int.Parse(input[2])- int.Parse(input[1]) + 1)).ToArray();
                            Console.WriteLine(string.Join(", ", a));
                        }
                        else
                        {
                            Console.WriteLine("The index does not exist!");
                            errorC++;
                        }
                        break;
                    case "Show":

                        if (!checkV(input[1])) break;
                        if (int.Parse(input[1]) <= nums.Count - 1 && int.Parse(input[1]) >= 0)
                        {
                            Console.WriteLine(nums[int.Parse(input[1])]);
                        }
                        else
                        {
                            Console.WriteLine("The index does not exist!");
                            errorC++;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }

        static bool checkV(string x)
        {
            int index;
            try
            {
                index = int.Parse(x);
                return true;
            }
            catch
            {
                Console.WriteLine("The variable is not in the correct format!");
                errorC++;
                return false;
            }
        }
    }
}
