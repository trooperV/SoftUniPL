using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double average;

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if(min > nums[i])
                {
                    min = nums[i];
                }

                if (max < nums[i])
                {
                    max = nums[i];
                }

                sum += nums[i];

            }

            average = sum / nums.Length;

            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);

        }
    }
}
