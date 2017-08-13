using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> places = new List<int>();
            foreach (int index in indexes)
            {
                if (index >= 0 && index < size)
                {
                    if (!places.Any(a => a == index))
                    {
                        places.Add(index);
                    }
                }
            }

            List<int> field = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if (places.Any(a => a == i))
                {
                    field.Add(1);
                }
                else
                {
                    field.Add(0);
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end") break;

                int index = int.Parse(input[0]);
                int str = int.Parse(input[2]);

                if (input[1] == "right")
                {
                    if (index >= 0 && index < size)
                    {
                        if (field[index] == 1)
                        {
                            field[index] = 0;
                            MoveRight(field, ref index, size, str);
                        }
                    }
                }
                else if (input[1] == "left")
                {
                    if (index >= 0 && index < size)
                    {
                        if (field[index] == 1)
                        {
                            field[index] = 0;
                            MoveLeft(field, ref index, size, str);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static void MoveLeft(List<int> field, ref int index, int size, int str)
        {
            if (index - str >= 0)
            {
                if (field[index - str] == 0)
                {
                    field[index - str] = 1;
                }
                else if (field[index - str] == 1)
                {
                    index -= str;
                    MoveLeft(field, ref index, size, str);
                }
            }
        }

        static void MoveRight(List<int> field, ref int index, int size, int str)
        {
            if (index + str < size)
            {
                if (field[index + str] == 0)
                {
                    field[index + str] = 1;
                }
                else if (field[index + str] == 1)
                {
                    index += str;
                    MoveRight(field, ref index, size, str);
                }
            }
        }
    }
}
