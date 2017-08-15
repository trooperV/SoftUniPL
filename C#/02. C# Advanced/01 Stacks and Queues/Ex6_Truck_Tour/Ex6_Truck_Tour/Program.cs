using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Queue<long> petrol = new Queue<long>();
            Queue<long> distance = new Queue<long>();

            for (long i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                petrol.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }

            if (petrol.Sum() < distance.Sum()) return;

            long pumpsGoneT = 0;
            long curIndex = 0;
            long curPumpsGoneT = 1;
            long curP = 0;
            long wIndex = -1;
            while (pumpsGoneT < n)
            {
                curP += petrol.Peek();
                if (curP >= distance.Peek())
                {
                    if (curPumpsGoneT == n)
                    {
                        Console.WriteLine(wIndex+1);
                        break;
                    }
                    curPumpsGoneT++;
                    curP -= distance.Peek();
                }  
                else
                {  
                    curP = 0;
                    curPumpsGoneT = 0;
                    pumpsGoneT ++;
                    wIndex = curIndex;
                }

                petrol.Enqueue(petrol.Dequeue());
                distance.Enqueue(distance.Dequeue());
                curIndex++;
                if (curIndex == n) curIndex = 0;
            }
        }
    }
}