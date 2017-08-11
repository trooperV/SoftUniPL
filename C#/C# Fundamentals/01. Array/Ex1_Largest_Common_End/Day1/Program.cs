using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join("\n", Console.ReadLine().Split(new[] { ' ', ',' },
            //    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray().Reverse()));

            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int uLength = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;

            string[] arrLeft = new string[uLength];
            string[] arrRight = new string[uLength];

            int cLeft = 0;
            int cRight = 0;

            //string l = "left";
            //string r = "right";

            Scan(arr1, arr2, ref cLeft, arrLeft, uLength);

            RArray(arr1);
            RArray(arr2);

            Scan(arr1, arr2, ref cRight, arrRight, uLength);

            //Console.WriteLine("\n{0} | The largest common end is at the {1}: {2}\n",
            //    cLeft > cRight ? cLeft : cRight, cLeft > cRight ? l : r, string.Join(" ", cLeft > cRight ? arrLeft : arrRight));

            Console.WriteLine(cLeft > cRight ? cLeft : cRight);

            

        }

        static void Scan(string[] arr1, string[] arr2, ref int count, string[] arrDone, int uLength)
        {
            bool bCount = false;

            for (int i = 0; i < uLength; i++)
            {
                if (arr1[0] == arr2[0] && bCount == false)
                {
                    if (i != 0) break;

                    bCount = true;
                    count++;
                    arrDone[0] = arr1[0];
                    continue;
                }

                if (i != 0 && arr1[i] == arr2[i] && arr1[i - 1] == arr2[i - 1] && bCount == true)
                {
                    count++;
                    arrDone[i] = arr1[i];
                }
            }
        }

        static void RArray(string[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                string tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
        }
    }
}
