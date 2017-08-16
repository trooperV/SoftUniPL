using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<long> nums = new Queue<long>();
            Queue<long> nums2 = new Queue<long>();
            long n = long.Parse(Console.ReadLine());

            nums.Enqueue(n);
            long cur = n;
            long po = 1;
            long add = 1;
            while (nums.Count < 50)
            {
                nums.Enqueue(po * cur + add);
                nums2.Enqueue(po * cur + add);
                if (add == 1 && po == 1)
                {
                    po = 2;
                }
                else if (add == 1 && po == 2)
                {
                    add = 2;
                    po = 1;
                }
                else if (add == 2 && po == 1)
                {
                    add = 1;
                }

                if (nums.Count % 3 == 1)
                {
                    cur = nums2.Dequeue();
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
